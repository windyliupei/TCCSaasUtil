using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocketServerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["Port"]);

            var wssv = new WebSocketServer(IPAddress.Any, port);
            wssv.AddWebSocketService<Echo>("/Echo");
            wssv.AddWebSocketService<Laputa>("/Laputa");
            wssv.Start();

            Console.WriteLine(string.Format("Server Started:{0}",port));

            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
            wssv.Stop();
        }
    }
}
