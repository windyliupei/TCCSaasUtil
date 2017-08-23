using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NATS.Client;

namespace WebSocketClient
{
    public class NetClientTls
    {
        public void TlsDemo()
        {
            Options opts = ConnectionFactory.GetDefaultOptions();
            opts.Secure = true;

            // .NET requires the private key and cert in the
            //  same file. 'client.pfx' is generated from:
            //
            // openssl pkcs12 -export -out client.pfx
            //    -inkey client-key.pem -in client-cert.pem
            X509Certificate2 cert = new X509Certificate2("client.pfx", "password");

            opts.AddCertificate(cert);

            IConnection c = new ConnectionFactory().CreateConnection(opts);
        }

        public void TlsDemo2()
        {
            Options opts = ConnectionFactory.GetDefaultOptions();
            opts.Secure = true;
            opts.TLSRemoteCertificationValidationCallback = verifyServerCert;
            opts.AddCertificate("client.pfx");

            IConnection c = new ConnectionFactory().CreateConnection(opts);
        }


        private bool verifyServerCert(object sender,
            X509Certificate certificate, X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            // Do what is necessary to achieve the level of
            // security you need given a policy error.
            return false;
        }        
    }
}
