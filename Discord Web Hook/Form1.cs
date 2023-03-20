using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Web_Hook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void sendwebhooksender(string Url, string msg, string Username)
        {
            Https.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "Username",
                    Username
                },
                {
                    "content",
                    msg
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendwebhooksender(textBox2.Text, textBox1.Text, textBox3.Text);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}
    }
}
