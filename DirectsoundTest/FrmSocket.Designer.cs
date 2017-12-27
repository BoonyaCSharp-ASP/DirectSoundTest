namespace DirectsoundTest
{
    partial class FrmSocket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBindSocketServer = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnSocketClient = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.listViewData = new System.Windows.Forms.ListView();
            this.lblText = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSoundTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlSocket = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip.SuspendLayout();
            this.tabControlSocket.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBindSocketServer
            // 
            this.btnBindSocketServer.Location = new System.Drawing.Point(25, 19);
            this.btnBindSocketServer.Name = "btnBindSocketServer";
            this.btnBindSocketServer.Size = new System.Drawing.Size(75, 23);
            this.btnBindSocketServer.TabIndex = 0;
            this.btnBindSocketServer.Text = "启动服务器Socket";
            this.btnBindSocketServer.UseVisualStyleBackColor = true;
            this.btnBindSocketServer.Click += new System.EventHandler(this.btnBindSocketServer_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(159, 19);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(156, 21);
            this.textBox.TabIndex = 2;
            // 
            // btnSocketClient
            // 
            this.btnSocketClient.Location = new System.Drawing.Point(358, 17);
            this.btnSocketClient.Name = "btnSocketClient";
            this.btnSocketClient.Size = new System.Drawing.Size(75, 23);
            this.btnSocketClient.TabIndex = 3;
            this.btnSocketClient.Text = "客户端发送消息";
            this.btnSocketClient.UseVisualStyleBackColor = true;
            this.btnSocketClient.Click += new System.EventHandler(this.btnSocketClient_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(23, 58);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(107, 12);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "服务端搜到的消息:";
            // 
            // listViewData
            // 
            this.listViewData.Location = new System.Drawing.Point(25, 85);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(507, 232);
            this.listViewData.TabIndex = 5;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(118, 22);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 12);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "消息:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSoundTest});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(581, 25);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemSoundTest
            // 
            this.toolStripMenuItemSoundTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemServer,
            this.toolStripMenuItemClient});
            this.toolStripMenuItemSoundTest.Name = "toolStripMenuItemSoundTest";
            this.toolStripMenuItemSoundTest.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItemSoundTest.Text = "录音测试";
            // 
            // toolStripMenuItemServer
            // 
            this.toolStripMenuItemServer.Name = "toolStripMenuItemServer";
            this.toolStripMenuItemServer.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemServer.Text = "服务端";
            this.toolStripMenuItemServer.Click += new System.EventHandler(this.toolStripMenuItemServer_Click);
            // 
            // toolStripMenuItemClient
            // 
            this.toolStripMenuItemClient.Name = "toolStripMenuItemClient";
            this.toolStripMenuItemClient.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemClient.Text = "客户端";
            this.toolStripMenuItemClient.Click += new System.EventHandler(this.toolStripMenuItemClient_Click);
            // 
            // tabControlSocket
            // 
            this.tabControlSocket.Controls.Add(this.tabPage1);
            this.tabControlSocket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSocket.Location = new System.Drawing.Point(0, 25);
            this.tabControlSocket.Name = "tabControlSocket";
            this.tabControlSocket.SelectedIndex = 0;
            this.tabControlSocket.Size = new System.Drawing.Size(581, 364);
            this.tabControlSocket.TabIndex = 8;
            this.tabControlSocket.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBindSocketServer);
            this.tabPage1.Controls.Add(this.listViewData);
            this.tabPage1.Controls.Add(this.lblText);
            this.tabPage1.Controls.Add(this.lblMsg);
            this.tabPage1.Controls.Add(this.textBox);
            this.tabPage1.Controls.Add(this.btnSocketClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sokcet测试";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FrmSocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 389);
            this.Controls.Add(this.tabControlSocket);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmSocket";
            this.Text = "FrmSocket";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlSocket.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBindSocketServer;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnSocketClient;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSoundTest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemServer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClient;
        private System.Windows.Forms.TabControl tabControlSocket;
        private System.Windows.Forms.TabPage tabPage1;
    }
}