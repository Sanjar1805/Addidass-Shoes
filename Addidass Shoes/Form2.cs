using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addidass_Shoes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void ButtonColorChangeByClisk(Button bt1, Button bt2, Button bt3, Button bt4, Button bt5)
        {
            bt1.BackColor = Color.FromArgb(0, 122, 204);
            bt2.BackColor = Color.FromArgb(28, 28, 28);
            bt3.BackColor = Color.FromArgb(28, 28, 28);
            bt4.BackColor = Color.FromArgb(28, 28, 28);
            bt5.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            ButtonColorChangeByClisk(Homebutton, Customersbutton, Salesbutton, Purchasebutton,Reportsbutton);
        }

        private void Customersbutton_Click(object sender, EventArgs e)
        {
            ButtonColorChangeByClisk( Customersbutton, Homebutton, Salesbutton, Purchasebutton, Reportsbutton);
        }

        private void Salesbutton_Click(object sender, EventArgs e)
        {
            ButtonColorChangeByClisk( Salesbutton, Homebutton, Customersbutton, Purchasebutton, Reportsbutton);
        }

        private void Purchasebutton_Click(object sender, EventArgs e)
        {
            ButtonColorChangeByClisk(Purchasebutton, Homebutton, Customersbutton, Salesbutton, Reportsbutton);
        }

        private void Reportsbutton_Click(object sender, EventArgs e)
        {
            ButtonColorChangeByClisk(Reportsbutton, Homebutton, Customersbutton, Salesbutton, Purchasebutton);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
