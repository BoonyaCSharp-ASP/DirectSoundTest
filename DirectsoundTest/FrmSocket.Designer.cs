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
            this.SuspendLayout();
            // 
            // btnBindSocketServer
            // 
            this.btnBindSocketServer.Location = new System.Drawing.Point(35, 36);
            this.btnBindSocketServer.Name = "btnBindSocketServer";
            this.btnBindSocketServer.Size = new System.Drawing.Size(75, 23);
            this.btnBindSocketServer.TabIndex = 0;
            this.btnBindSocketServer.Text = "启动服务器Socket";
            this.btnBindSocketServer.UseVisualStyleBackColor = true;
            this.btnBindSocketServer.Click += new System.EventHandler(this.btnBindSocketServer_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(182, 37);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(156, 21);
            this.textBox.TabIndex = 2;
            // 
            // btnSocketClient
            // 
            this.btnSocketClient.Location = new System.Drawing.Point(384, 35);
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
            this.lblMsg.Location = new System.Drawing.Point(35, 92);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(107, 12);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "服务端搜到的消息:";
            // 
            // listViewData
            // 
            this.listViewData.Location = new System.Drawing.Point(37, 121);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(422, 128);
            this.listViewData.TabIndex = 5;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(140, 41);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 12);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "消息:";
            // 
            // FrmSocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 261);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSocketClient);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnBindSocketServer);
            this.Name = "FrmSocket";
            this.Text = "FrmSocket";
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
    }
}