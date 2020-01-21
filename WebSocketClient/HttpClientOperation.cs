using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Threading;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace WebSocketClient
{
    public class HttpClientOperation
    {
        X509Certificate2 x509Certificate2 = null;
        public HttpResponseMessage SendRequestAsync(HttpMethod method, string uri, HttpContent body,
            CancellationToken cancellationToken,
            string contentType = "application/json", Dictionary<string, string> hearders = null, List<Cookie> cookies = null)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            //HttpClientHandler handler = new HttpClientHandler {CookieContainer = new CookieContainer()};
            WebRequestHandler handler = new WebRequestHandler();
            using (handler)
            {
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.CookieContainer = new CookieContainer();

                CookieCollection cookieCollection = new CookieCollection();

                if (cookies != null)
                {
                    foreach (Cookie cookie in cookies)
                    {
                        cookieCollection.Add(cookie);
                    }
                }
                handler.CookieContainer.Add(cookieCollection);

                using (var httpClient = new HttpClient(handler))
                {
                    handler.ServerCertificateValidationCallback = CheckValidationResult;

                    if (body != null)
                    {
                        body.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
                        if (hearders != null)
                        {
                            foreach (string key in hearders.Keys)
                            {
                                body.Headers.Add(key, hearders[key]);
                            }
                        }
                    }
                    try
                    {
                        switch (method.Method.ToLower())
                        {
                            case "get":
                                response = httpClient.GetAsync(uri, cancellationToken).Result;
                                break;
                            case "post":
                                response = httpClient.PostAsync(uri, body, cancellationToken).Result;
                                break;
                            case "put":
                                response = httpClient.PutAsync(uri, body, cancellationToken).Result;
                                break;
                            case "delete":
                                if (body == null)
                                {
                                    response = httpClient.DeleteAsync(uri, cancellationToken).Result;
                                }
                                else
                                {
                                    response = httpClient.SendAsync(
                                        new HttpRequestMessage(System.Net.Http.HttpMethod.Delete, uri)
                                        {
                                            Content = body
                                        }, cancellationToken).Result;
                                }
                                break;
                            default:
                                throw new ArgumentOutOfRangeException("method");
                        }
                        if (response == null)
                        {
                            throw new Exception("response is null");
                        }
                    }
                    catch (Exception ex)
                    {
                        response.StatusCode = HttpStatusCode.InternalServerError;
                        response.ReasonPhrase = ex.Message;
                    }
                }
                return response;
            }
        }

        private bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors)
        {
            return true;
        }

        #region Remote certification validate 
        public bool RemoteCertificateValidate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (null != x509Certificate2)
            {
                /*
                 * 根证书未安装到“受信任的根证书颁发机构”时，默认是无法形成可信证书链的。（chain中将只有服务器证书本身）
                 * 需更改链策略，然后重新构建证书链。
                */
                // 将我们的根证书放到链引擎可搜索到的地方
                chain.ChainPolicy.ExtraStore.Add(x509Certificate2);
                //不执行吊销检查
                chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                //忽略CA未知情况、不做时间检查
                chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority | X509VerificationFlags.IgnoreNotTimeNested | X509VerificationFlags.IgnoreNotTimeValid;
                //重新构建可信证书链
                bool isOk = chain.Build(certificate as X509Certificate2);
                if (isOk)
                {
                    //获取最前面的证书，认为是根证书
                    X509Certificate2 cacert = chain.ChainElements[chain.ChainElements.Count - 1].Certificate;
                    bool check = x509Certificate2.GetPublicKeyString().Equals(cacert.GetPublicKeyString()) && x509Certificate2.Thumbprint.Equals(cacert.Thumbprint);

                    HttpWebRequest req = sender as HttpWebRequest;

                    bool isOkForQaSt = certificate.Subject.Contains("CN=" + "*" + req.Address.Host.Substring(req.Address.Host.IndexOf(".")));
                    bool isOkForProduct = certificate.Subject.Contains("CN=" + req.Address.Host);

                    if (null != req && (isOkForQaSt || isOkForProduct))
                    {
                        //根证书可信且服务器证书确实是指定服务器的，验证通过
                        return true;
                    }

                }
            }
            return false;
        }
        #endregion




    }
}
