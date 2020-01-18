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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void НеУважаюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GfhfghToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

        }

        private void ДайДенегToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 form = new Form3();
            form.Show();            // 
        }
    }
}
