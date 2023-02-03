namespace Server
{
    partial class Server
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
            this.richTextChat = new System.Windows.Forms.RichTextBox();
            this.richTextServer = new System.Windows.Forms.RichTextBox();
            this.msgtxt = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextChat
            // 
            this.richTextChat.Location = new System.Drawing.Point(52, 25);
            this.richTextChat.Name = "richTextChat";
            this.richTextChat.ReadOnly = true;
            this.richTextChat.Size = new System.Drawing.Size(456, 341);
            this.richTextChat.TabIndex = 0;
            this.richTextChat.Text = "";
            this.richTextChat.TextChanged += new System.EventHandler(this.richTextChat_TextChanged);
            // 
            // richTextServer
            // 
            this.richTextServer.Location = new System.Drawing.Point(514, 25);
            this.richTextServer.Name = "richTextServer";
            this.richTextServer.ReadOnly = true;
            this.richTextServer.Size = new System.Drawing.Size(198, 338);
            this.richTextServer.TabIndex = 1;
            this.richTextServer.Text = "";
            this.richTextServer.TextChanged += new System.EventHandler(this.richTextServer_TextChanged);
            // 
            // msgtxt
            // 
            this.msgtxt.Location = new System.Drawing.Point(52, 372);
            this.msgtxt.Name = "msgtxt";
            this.msgtxt.Size = new System.Drawing.Size(456, 20);
            this.msgtxt.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(514, 369);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(70, 24);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(590, 369);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 24);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.msgtxt);
            this.Controls.Add(this.richTextServer);
            this.Controls.Add(this.richTextChat);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextChat;
        private System.Windows.Forms.RichTextBox richTextServer;
        private System.Windows.Forms.TextBox msgtxt;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}