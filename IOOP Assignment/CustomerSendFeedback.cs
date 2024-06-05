using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class CustomerSendFeedback : UserControl
    {
        string username = string.Empty;
        public string Username { get => username; set => username = value; }

        public CustomerSendFeedback()
        {
            InitializeComponent();
        }

        private void CustomerSendFeedback_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username))
            {
                username = char.ToUpper(username[0]) + username.Substring(1);
                lblGreetings.Text = $"Good day {username}, we hope thou grant us a feedback";
            }
            else
            {
                lblGreetings.Text = "Good day, we hope thou grant us a feedback";
            }
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            string feedback = rtbFeedback.Text;
            SendFeedback sendFeedback = new SendFeedback(username, feedback);

            //shows a notice through Message box if the feedback textbox is empty
            if (string.IsNullOrEmpty(feedback))
            {
                MessageBox.Show($"please dont leave the feedback empty :(");
            }
            else
            {
                sendFeedback.sendFeedback();
                MessageBox.Show($"Feedback is sent, thank you and have a nice day :)");
                rtbFeedback.Text = string.Empty;
                //testing
                //MessageBox.Show($"{username}....{feedback}");
            }
        }
    }
}
