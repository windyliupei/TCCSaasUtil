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
                    }
                }
                return response;
            }
        }

        private bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors)
        {
            return true;
        }
    }
}
