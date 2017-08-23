using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocketServerDemo
{
    public class Echo : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Send(e.Data);
        }

        protected override void OnOpen()
        {
            Console.WriteLine("There is a connection was connected!");
            base.OnOpen();
        }
    }
}
