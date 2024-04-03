using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Addidass_Shoes
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool status;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBox1.Checked == true)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            if (status == true)
            {
                FileInfo file4 = new FileInfo(@"D:\c# dasturlash tili\Addidass Shoes\Addidass Shoes.txt");
                StreamWriter writer = file4.CreateText();
                writer.WriteLine("login: " + textBox1.Text);
                writer.WriteLine("parol: " + textBox2.Text);
                writer.Close();
                MessageBox.Show("parollar saqlandi!.", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Sanjar") && textBox2.Text.Equals("123456"))
            {
                this.Hide();
                new Form2().Show();
            }
            else
            {
                MessageBox.Show("Login yoki parol hato", "Eror", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox1.Text = textBox2.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
                pictureBox5.BringToFront();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
                pictureBox4.BringToFront();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            login_form_1 nextForm = new login_form_1();
            nextForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            login_form_1 registerForm = new login_form_1();
            registerForm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
