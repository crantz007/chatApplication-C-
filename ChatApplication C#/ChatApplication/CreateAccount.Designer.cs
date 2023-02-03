namespace ChatApplication
{
    partial class CreateAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.psswtxt = new System.Windows.Forms.TextBox();
            this.confpsstxt = new System.Windows.Forms.TextBox();
            this.btn_create_acc = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usser Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(185, 82);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(206, 23);
            this.usernametxt.TabIndex = 3;
            // 
            // psswtxt
            // 
            this.psswtxt.Location = new System.Drawing.Point(185, 131);
            this.psswtxt.Name = "psswtxt";
            this.psswtxt.PasswordChar = '*';
            this.psswtxt.Size = new System.Drawing.Size(206, 23);
            this.psswtxt.TabIndex = 4;
            // 
            // confpsstxt
            // 
            this.confpsstxt.Location = new System.Drawing.Point(185, 172);
            this.confpsstxt.Name = "confpsstxt";
            this.confpsstxt.Size = new System.Drawing.Size(206, 23);
            this.confpsstxt.TabIndex = 5;
            // 
            // btn_create_acc
            // 
            this.btn_create_acc.Location = new System.Drawing.Point(112, 245);
            this.btn_create_acc.Name = "btn_create_acc";
            this.btn_create_acc.Size = new System.Drawing.Size(108, 38);
            this.btn_create_acc.TabIndex = 6;
            this.btn_create_acc.Text = "Create Account";
            this.btn_create_acc.UseVisualStyleBackColor = true;
            this.btn_create_acc.Click += new System.EventHandler(this.btn_create_acc_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(271, 245);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(103, 38);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Location = new System.Drawing.Point(266, 201);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(108, 19);
            this.checkBoxShowPass.TabIndex = 8;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Location = new System.Drawing.Point(112, 322);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(32, 15);
            this.linkHelp.TabIndex = 9;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Help";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 364);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_create_acc);
            this.Controls.Add(this.confpsstxt);
            this.Controls.Add(this.psswtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernametxt;
        private TextBox psswtxt;
        private TextBox confpsstxt;
        private Button btn_create_acc;
        private Button btn_close;
        private CheckBox checkBoxShowPass;
        private LinkLabel linkHelp;
    }
}