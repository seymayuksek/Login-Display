using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Login_Display
{
    public partial class loginForm : Form
    {
        string correctUsername = "seyma.yuksek";
        string correctPassword = "123456";

        public loginForm()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//namespace LoginFormExample
//{
//    public partial class MainForm : Form
//    {
//        //public MainForm()
//        //{
//        //    InitializeComponent();
//        //}
//        private void loginButton_Click(object sender, EventArgs e)
//        {
//            string username = userTextBox.Text;
//            string password = passwordTextBox.Text;
//            if (username == correctUsername && password == correctPassword)
//            {
//                MainForm mainForm = new MainForm();
//                mainForm.Show();
//                this.Hide();
//            }
//            else
//            {
//                MessageBox.Show("Wrong username or password. Please try again.");
//            }
//        }
//    }
//}
