using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectsoundTest
{
    public partial class FrmClient : Form
    {
        DirectSoundCapture directSoundCapture;

        Socket socket;

        public FrmClient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化Socket基础连接信息
        /// </summary>
        private void initSocket() {
            Console.WriteLine("客户端开启Socket......");
            Console.WriteLine("客户端开启Socket......"+ Dns.GetHostName());
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Setting.IP_ADDRESS);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, Setting.PORT);
            // Create a TCP/IP  socket.  
            socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            socket.Connect(remoteEP);// 与远端建立socket连接

            directSoundCapture = new DirectSoundCapture();

            directSoundCapture.LocalSocket = socket;//客户端Socket实例对象
            directSoundCapture.RemoteEndPoint = remoteEP;//连接远程服务端点
            directSoundCapture.NotifyNum = 1024;//每次发送的数量
            directSoundCapture.Intptr = new IntPtr(1024);//窗口句柄
            directSoundCapture.InitVoice();// 初始化声音设备
            directSoundCapture.StartVoiceCapture();//开启声音采集

            Console.WriteLine("客户端开启Socket...并初始化参数配置完成.");

        }

        /// <summary>
        /// 关闭客户端录音
        /// </summary>
        private void closeSocket() {
            // close sound capture
            directSoundCapture.Stop();
            directSoundCapture = null;

            // Release the socket.  
            byte[] msg = Encoding.UTF8.GetBytes("关闭连接" + "<EOF>");
            socket.Send(msg);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        /// <summary>
        /// 开始录音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if ("开始录音".Equals(btnStart.Text.ToString()))
            {
                initSocket();// 初始化Socket
                btnStart.Text = "停止录音";
            }
            else if ("停止录音".Equals(btnStart.Text.ToString())) {
                closeSocket();//关闭Socket连接
                btnStart.Text = "开始录音";
            }
            
        }

        /// <summary>
        /// 设置默认统一IP和端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmClient_Load(object sender, EventArgs e)
        {
            textBox1.Text = "" + Setting.IP_ADDRESS;
            textBox2.Text = ""+Setting.PORT;
        }

        /// <summary>
        /// IP改变事件修改IP值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Setting.IP_ADDRESS = textBox1.Text;
        }

        /// <summary>
        /// 端口改变事件修改端口值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try {
                Setting.PORT = Int32.Parse(textBox2.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
