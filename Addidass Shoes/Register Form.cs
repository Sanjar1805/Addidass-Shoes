using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addidass_Shoes
{
    public partial class login_form_1 : Form
    {
        public login_form_1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            void ButtonColorChangeByClick(Button activeButton, params Button[] otherButtons)
            {
                activeButton.BackColor = Color.Green; 
                foreach (Button button in otherButtons)
                {
                    button.BackColor = SystemColors.Control; 
                }
            }
        }

        private void login_form_1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          // Tashuvchi tashuvchi = new Tashuvchi();

           List<string> list= new List<string>();
            list.Add(textBox1.Text);
            list.Add(textBox2.Text);
            if (textBox1.Text == textBox2.Text)
            {
                list.Add(textBox3.Text);
                list.Add(textBox4.Text);
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else
            {
                label7.ForeColor= Color.Red;
                label2.ForeColor= Color.Red;
                label9.ForeColor= Color.Red;
                label1.ForeColor= Color.Red;
                label8.ForeColor= Color.Red;
                textBox1.Text = textBox2.Text="";
                label8.Text = "Parollar bir biriga mos emas!. qaytadan kiriting.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_form().Show();
            
        }
    }
}
