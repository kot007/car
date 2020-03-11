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
    public partial class CarDetailForm : Form
    {
        Car car;

        public CarDetailForm(Car car1)
        {
            car = car1;
            InitializeComponent();
            
            pictureBox1.Load("../../Pictures/" + car.name +".jpg");
            Text = "Автомобиль " + car.name;
            textBox1.Text = car.name;
            label1.Text = car.price.ToString();
            //car.price

            if (car.name == "Pagani Zonda")
            {
                textBox1.Text += 
                    Environment.NewLine + "Максимальная скорость 330 км / ч" +
                    Environment.NewLine + "Мощность 700 л.с.";
            }
            if (car.name == "KIA Optima")
            {
                textBox1.Text +=
                    Environment.NewLine + "Максимальная скорость 220 км / ч" +
                    Environment.NewLine + "Мощность 200 л.с.";
            }
        }

        private void CarDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            korzina.Zametki.Add(car);
        }
    }
}
