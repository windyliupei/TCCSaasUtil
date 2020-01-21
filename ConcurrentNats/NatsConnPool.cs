using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NATS.Client;
using System.Collections.Concurrent;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace ConcurrentNats
{
    public class NatsConnPool
    {
        private SemaphoreSlim _slim;
        private ConcurrentStack<IConnection> _stack;
        private static NatsConnPool _instance;
        private static int _maxConn;

        [Obsolete]
        public static NatsConnPool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NatsConnPool();
                }
                return _instance;
            }
        }

        public int MaxConnections { get; private set; }

        [Obsolete]
        private NatsConnPool()
        {
            _maxConn = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["maxClientConnCount"]);
            _slim = new SemaphoreSlim(1, _maxConn);//
        }

        [Obsolete]
        private void InitPool()
        {
            _stack = new ConcurrentStack<IConnection>();

            for (int i = 0; i < _maxConn; i++)
            {
                IConnection conn = CreateConnection();
                _stack.Push(conn);
            }
        }

        [Obsolete]
        private static IConnection CreateConnection()
        {
            Options opts = ConnectionFactory.GetDefaultOptions();
            opts.MaxReconnect = 10;
            opts.PingInterval = 1000;
            opts.Secure = true;
            opts.MaxPingsOut = int.MaxValue;
            opts.Timeout = int.MaxValue;
            var servers = System.Configuration.ConfigurationSettings.AppSettings["natsServer"];
            opts.Servers = servers.Split(',');
            //opts.TLSRemoteCertificationValidationCallback = TlsRemoteCertificationValidationCallback;
            opts.User = "home";
            opts.Password = "1qaz2wsx";
            X509Certificate2 cert = new X509Certificate2("cert/clientcert.pfx_", "111111");
            opts.AddCertificate(cert);
            ConnectionFactory cf = new ConnectionFactory();
            IConnection conn = cf.CreateConnection(opts);
            return conn;
        }

        [Obsolete]
        public IConnection Pop()
        {
            _slim.Wait();

            IConnection clientConn;
            _stack.TryPop(out clientConn);

            if (clientConn.IsClosed() && !clientConn.IsReconnecting()) {
                //TODO: Reconn manully
                clientConn = CreateConnection();
            }

            return clientConn;
        }

        public void Push(IConnection clientConn)
        {
            _stack.Push(clientConn);
            _slim.Release();
        }
    }
}
