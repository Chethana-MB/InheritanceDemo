using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class father
        {
            public void maruticar()
            {
               
                    MessageBox.Show("Maruti car..");
                
            }
        }
        class Son : father
        {
            public void MBCar()
            {
                MessageBox.Show("Mercedes car..");
            }
        }
        class grandson : Son
        {
            public void HondaCar()
            {
                MessageBox.Show("Honda car..");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grandson gs = new grandson();
            gs.maruticar();
            gs.HondaCar();
            gs.MBCar();
            father f = new father();    
            f.maruticar();
            Son s = new Son();  
            s.maruticar();
            gs.HondaCar();
        }
    }
}
