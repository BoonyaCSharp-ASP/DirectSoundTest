using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectsoundTest
{
    public partial class FrmServer : Form
    {

        public static Boolean isRuning = true;

        public FrmServer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化服务端Socket监听
        /// </summary>
        public void listening() {
            Console.WriteLine("服务端开启Socket......");
            // Data buffer for incoming data.  
            byte[] bytes = new Byte[1024];
            Console.WriteLine("服务端开启Socket......" + Dns.GetHostName());
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Setting.IP_ADDRESS);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, Setting.PORT);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(localEndPoint);
            listener.Listen(10);
            Console.WriteLine("服务端已开启Socket.....listening.");


            //开启服务端处理客户端数据线程===去掉此处代码会导致音频断路
            Thread thread = new Thread(() =>
            {

                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    // Program is suspended while waiting for an incoming connection.  
                    Socket handler = listener.Accept();

                    // An incoming connection needs to be processed.  
                    while (true && isRuning)
                    {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        Console.Write("Received sound data:");
                        foreach (byte b in bytes) {
                            Console.Write(b);
                        }

                        // close current socket 
                        string data = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Break a connection ....");
                            break;
                        }
                    }

                    // Show the data on the console.  
                   

                    // Echo the data back to the client.  
                    byte[] msg = Encoding.UTF8.GetBytes("回复客户端消息");

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// 开启Socket服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServerListen_Click(object sender, EventArgs e)
        {
            btnServerListen.Enabled = false;

            listening();//开启Socket监听服务

            this.Visible = false;
        }
    }
}
