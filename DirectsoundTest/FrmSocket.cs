using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectsoundTest
{
    public partial class FrmSocket : Form
    {
        public FrmSocket()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 启动服务端socket连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBindSocketServer_Click(object sender, EventArgs e)
        {
            btnBindSocketServer.Enabled = false;
            Thread thread = new Thread(() => {
                SocketServer.StartListening();
            });
            thread.IsBackground = true;
            thread.Start();

        }

        /// <summary>
        /// 客户端发送socket连接数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSocketClient_Click(object sender, EventArgs e)
        {
            // 发送UTF8文字
            byte[] buffer = Encoding.UTF8.GetBytes(this.textBox.Text.ToString());
            string data = Encoding.UTF8.GetString(buffer);
            listViewData.Items.Add(data);

            Thread thread = new Thread(() => {
                SocketClient.StartClient(data);
            });
            thread.IsBackground = true;
            thread.Start();

        }

        /// <summary>
        /// 打开服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemServer_Click(object sender, EventArgs e)
        {
            if (!Setting.SERVER_BINDED)
            {
                FrmServer frmServer = new FrmServer();
                frmServer.Show();
                Setting.SERVER_BINDED = true;
            }
            else {
                MessageBox.Show("服务端已注册");
            }
        }

        /// <summary>
        /// 打开客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemClient_Click(object sender, EventArgs e)
        {
            FrmClient frmClient = new FrmClient();
            frmClient.Show();
        }
    }
}
