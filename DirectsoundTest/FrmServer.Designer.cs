namespace DirectsoundTest
{
    partial class FrmServer
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
            this.btnServerListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServerListen
            // 
            this.btnServerListen.Location = new System.Drawing.Point(91, 22);
            this.btnServerListen.Name = "btnServerListen";
            this.btnServerListen.Size = new System.Drawing.Size(75, 23);
            this.btnServerListen.TabIndex = 0;
            this.btnServerListen.Text = "开启服务";
            this.btnServerListen.UseVisualStyleBackColor = true;
            this.btnServerListen.Click += new System.EventHandler(this.btnServerListen_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 80);
            this.Controls.Add(this.btnServerListen);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmServer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServerListen;
    }
}