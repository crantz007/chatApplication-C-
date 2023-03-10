using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Login : Form
    {
        // Socket exception // Kill connection
        public bool ServerDead;
        // Setting socket to make request via login form
        public bool LoggedIn;
        // Client class to pass to encryption
        private ClientData _Client;
        // Encryption calss
        EncryptionClient encryptionAES = new();
        //Client client = new();

        // Socket data
        Socket _ServerSocket;
        byte[] _buffer = new byte[1024];

        public Login(Socket ServerSocket, ClientData clientData)
        {
            InitializeComponent();
            _ServerSocket = ServerSocket; //Make equal
            _Client = clientData;
            // Set timeouts for syncronous methods
            _ServerSocket.SendTimeout = 2000;
            _ServerSocket.ReceiveTimeout = 2000;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string AllowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!?_";

            // If the username and password are not empty
            if (usernametxt.Text != "" && psswtxt.Text != "")
            {
                if (usernametxt.Text.All(c => AllowedCharacters.Contains(c)))
                {
                    if (usernametxt.Text.Length <= 16)
                    {
                        if (psswtxt.Text.Length <= 256)
                        {
                            if (LoginIsAllowed(usernametxt.Text, psswtxt.Text))
                            {
                                _Client.Name = usernametxt.Text;
                                MessageBox.Show("Sucess, logged in.", "Login", MessageBoxButtons.OK, MessageBoxIcon.None);
                                LoggedIn = true;
                                this.Close();
                            }
                            else
                                //MessageBox.Show("Incorrect username or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ClearAllBoxes();
                        }
                        else
                            MessageBox.Show("Max password length is 256 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        psswtxt.Clear();
                    }
                    else
                        MessageBox.Show("Max username length is 16 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearAllBoxes();
                }
                else
                    MessageBox.Show("Only letters and numbers and !?_ are allowed in username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearAllBoxes();
            }
            else
                MessageBox.Show("Please enter a username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ClearAllBoxes()
        {
            usernametxt.Clear();
            psswtxt.Clear();
        }



            private bool LoginIsAllowed(string name, string password)
        {
            try
            {
                // No message as we are client, server only has a message
                DataSerializer DD = new(usernametxt.Text, psswtxt.Text, "");

                // Syncronous send and recieve
                byte[] EncryptedLoginPacket = encryptionAES.EncryptDataBufferAES(DD.LoginPacketToByteArray(), _Client);
                _ServerSocket.Send(EncryptedLoginPacket, 0, EncryptedLoginPacket.Length, SocketFlags.None);

                int recievedAes = _ServerSocket.Receive(_buffer);

                Array.Resize(ref _buffer, recievedAes);
                byte[] decryptedBuffer = encryptionAES.DecryptDataBufferAES(_buffer, _Client);
                DataSerializer DD2 = new(decryptedBuffer);

                if (DD2.Message == "True")
                {
                    // Login sucessful // SetUserName 
                    return true;
                }
                // user is already logged in so no you cant log in.
                else if (DD2.Message == "Login")
                {
                    MessageBox.Show("User is already logged in.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Incorrect username or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (SocketException ex)
            {
                ServerDead = true;
                MessageBox.Show($"Socket exception, error. Target machine not responding. Timeout.\n\nTraceback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Need to disable login and create account and require the user to re connect
                this.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login responce error.\n\nTraceback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Formatting help:\n\n-Max password length is 256 characters.\n-Max username length is 16 characters.\n-Only letters and numbers and !?_ are allowed in username.\n-Please enter a username and password.\n\nForgot your password? That's on you", "Login - help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            //TxtBoxPassword.PasswordChar = '*';
            if (checkBoxShowPass.Checked)
            {
                psswtxt.UseSystemPasswordChar = false;
            }
            else if (!checkBoxShowPass.Checked)
            {
                psswtxt.UseSystemPasswordChar = true;
            }
        }
    }
    
}
