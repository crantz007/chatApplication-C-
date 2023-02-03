namespace ChatApplication
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.IPDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richtxtBoxConnInfo = new System.Windows.Forms.RichTextBox();
            this.richtxtboxMain = new System.Windows.Forms.RichTextBox();
            this.richtxtDebug = new System.Windows.Forms.RichTextBox();
            this.msgtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(33, 71);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(118, 38);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(33, 117);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(118, 38);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_account
            // 
            this.btn_account.Location = new System.Drawing.Point(33, 161);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(118, 38);
            this.btn_account.TabIndex = 2;
            this.btn_account.Text = "Create Account";
            this.btn_account.UseVisualStyleBackColor = true;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(33, 369);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(118, 38);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // IPDropDown
            // 
            this.IPDropDown.FormattingEnabled = true;
            this.IPDropDown.Location = new System.Drawing.Point(27, 31);
            this.IPDropDown.Name = "IPDropDown";
            this.IPDropDown.Size = new System.Drawing.Size(144, 23);
            this.IPDropDown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recently Connected Hosts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Connection Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Diagnostic /Debug";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chat Window";
            // 
            // richtxtBoxConnInfo
            // 
            this.richtxtBoxConnInfo.Location = new System.Drawing.Point(34, 238);
            this.richtxtBoxConnInfo.Name = "richtxtBoxConnInfo";
            this.richtxtBoxConnInfo.ReadOnly = true;
            this.richtxtBoxConnInfo.Size = new System.Drawing.Size(127, 118);
            this.richtxtBoxConnInfo.TabIndex = 11;
            this.richtxtBoxConnInfo.Text = "";
            // 
            // richtxtboxMain
            // 
            this.richtxtboxMain.Location = new System.Drawing.Point(207, 56);
            this.richtxtboxMain.Name = "richtxtboxMain";
            this.richtxtboxMain.ReadOnly = true;
            this.richtxtboxMain.Size = new System.Drawing.Size(370, 309);
            this.richtxtboxMain.TabIndex = 12;
            this.richtxtboxMain.Text = "";
            this.richtxtboxMain.TextChanged += new System.EventHandler(this.richtxtboxMain_TextChanged);
            // 
            // richtxtDebug
            // 
            this.richtxtDebug.Location = new System.Drawing.Point(601, 56);
            this.richtxtDebug.Name = "richtxtDebug";
            this.richtxtDebug.ReadOnly = true;
            this.richtxtDebug.Size = new System.Drawing.Size(157, 303);
            this.richtxtDebug.TabIndex = 13;
            this.richtxtDebug.Text = "";
            // 
            // msgtxt
            // 
            this.msgtxt.Location = new System.Drawing.Point(226, 381);
            this.msgtxt.Name = "msgtxt";
            this.msgtxt.Size = new System.Drawing.Size(473, 23);
            this.msgtxt.TabIndex = 14;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgtxt);
            this.Controls.Add(this.richtxtDebug);
            this.Controls.Add(this.richtxtboxMain);
            this.Controls.Add(this.richtxtBoxConnInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPDropDown);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_connect);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_connect;
        private Button btn_login;
        private Button btn_account;
        private Button btn_send;
        private ComboBox IPDropDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox richtxtBoxConnInfo;
        private RichTextBox richtxtboxMain;
        private RichTextBox richtxtDebug;
        private TextBox msgtxt;
    }
}