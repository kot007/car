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
    public struct Car
    {
        public string name;
        public string Klass;
        public int price;
        public Button btn;

        public Car(string NameCar, string KlassCar, int priceCar, Button b)
        {
            name = NameCar;
            Klass = KlassCar;
            price = priceCar;
            btn = b;

        }
    }


    public partial class Filtr : Form
    {

        Car[] cars = new Car[1000];



        public Filtr()
        {
            InitializeComponent();

            cars[0] = new Car("KIA Optima", "Бизнес", 60000, button2);
            cars[1] = new Car("Toyota Camry", "Бизнес", 390000, button5);
            cars[2] = new Car("Ford Focus 3", "Бизнес", 350000, button4);
            cars[3] = new Car("KIA rio", "Бизнес", 300000, button3);
            cars[4] = new Car("Renault Fluence", "Бизнес", 458000, button6);
            cars[5] = new Car("WF Polo", "Бизнес", 290000, button7);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                cars[i].btn.Visible = true;

                if (minPriceTextBox.Text != "" &&
                    cars[i].price < Convert.ToInt32(minPriceTextBox.Text))
                {
                    cars[i].btn.Visible = false;
                }

                if (minPriceTextBox.Text != "" &&
                    cars[i].price > Convert.ToInt32(maxPriceTextBox.Text))
                {
                    cars[i].btn.Visible = false;
                }



                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    cars[i].btn.Visible = false;
                    for (int k = 0; k < checkedListBox1.CheckedItems.Count; k = k + 1)
                    {
                        if (checkedListBox1.CheckedItems[k].ToString() == cars[i].Klass)
                        {
                            cars[i].btn.Visible = true;
                        }
                    }
                }
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Button1_Click(null, null);

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
