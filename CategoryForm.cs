using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class CategoryForm : Form
    {
        public CategoryForm(string category)
        {
            InitializeComponent();

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            

            Text = "Автомобили класса " + category;
            if (category == "Суперкары")
            {
                button1.Text = "Pagani Zonda";
                button2.Text = "McLaren Senna";
                button3.Visible = false;
            }
            else if (category == "Бюджетные авто")
            {
                button1.Text = "Renault Logan";
                button2.Visible = false;
                button3.Visible = false;
            }
            else if (category == "Бизнес-класс")
            {
                button1.Text = "KIA Optima";
                button2.Text = "Toyota Camry";
                button3.Text = "Ford Focus 3";
                button4.Text = "KIA rio";
                button5.Text = "Renault Fluence";
                button6.Text = "WF Polo";
            }
            else if (category == "Внедорожники")
            {
                button2.Text = "Ford Raptor"; 
            }
            else if (category == "Премиум")
            {
                button2.Text = "Mersedes 221";
            }
            else if (category == "Классика")
            {
                button2.Text = "Mersedes 124";
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }

            if (button1.Text != "")
            {
                pictureBox1.Load("../../Pictures/" + button1.Text + ".jpg");
            }
            if (button2.Text != "")
            {
                pictureBox2.Load("../../Pictures/" + button2.Text + ".jpg");
            }
            if (button3.Text != "")
            {
                pictureBox3.Load("../../Pictures/" + button3.Text + ".jpg");
            }
            if (button4.Text != "")
            {
                pictureBox4.Load("../../Pictures/" + button4.Text + ".jpg");
            }
            if (button5.Text != "")
            {
                pictureBox5.Load("../../Pictures/" + button5.Text + ".jpg");
            }
            if (button6.Text != "")
            {
                pictureBox6.Load("../../Pictures/" + button6.Text + ".jpg");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CarDetailForm form = new CarDetailForm(button1.Text);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarDetailForm form = new CarDetailForm(button2.Text);
            form.Show();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
