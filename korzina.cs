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
    public partial class korzina : Form
    {
        public static List<Car> Zametki = new List<Car>();

        public korzina()
        {
            InitializeComponent();

            foreach (Car car in Zametki)
            {
                Button btn = new Button();
                btn.Font = car.btn.Font;
                btn.Location = car.btn.Location;
                btn.Size = car.btn.Size;
                btn.Text = car.btn.Text;
                btn.Click += Filtr.openCar;
                
                Controls.Add(btn);
            }
        }

        private void Korzina_Load(object sender, EventArgs e)
        {

        }
    }
}
