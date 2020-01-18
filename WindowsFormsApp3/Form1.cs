using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ты ", "ты близок к ответу?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Нет, ты идиот");
            }

            button2.Text = "Лох";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ты идиот?", "Ты идиот?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Нет, ты идиот");
            }
        }
    }
}
