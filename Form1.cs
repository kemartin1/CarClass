using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClass
{
    public partial class Form1 : Form
    {
        Car myCar;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMake.Text == String.Empty || txtYear.Text == String.Empty || txtModel.Text == String.Empty)
                    MessageBox.Show("All data must be filled!");
                else
                {
                    createCar();
                    label8.Text = txtYear.Text + " " + txtMake.Text + " " + txtModel.Text;
                }
            }
                catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (myCar.Tank <= .25)
                {
                    MessageBox.Show("Your car needs to be filled with gas first!");
                    myCar.Speed = 0;
                    lblMph.Text = myCar.Speed.ToString();
                }
                else
                {
                    myCar.Speed += 5;
                    myCar.Tank -= .25;
                    lblMph.Text = myCar.Speed.ToString();
                    lblGas.Text = myCar.Tank.ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void createCar()
        {
            myCar = new Car(txtYear.Text, txtMake.Text, txtModel.Text);
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            try
            {
                if (myCar.Tank <= .25)
                {
                    MessageBox.Show("Your car needs to be filled with gas first!");
                    myCar.Speed = 0;
                    lblMph.Text = myCar.Speed.ToString();
                }
                else if(myCar.Speed <= 5)
                {
                    MessageBox.Show("Someone is brake happy >:(");
                    myCar.Speed = 0;
                    lblMph.Text = myCar.Speed.ToString();
                }
                else
                {
                    myCar.Speed -= 5;
                    myCar.Tank -= .10;
                    lblMph.Text = myCar.Speed.ToString();
                    lblGas.Text = myCar.Tank.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                if (myCar.Tank >= 13)
                    MessageBox.Show("Your car is Full!");
                else
                {
                    myCar.Speed = 0;
                    myCar.Tank += 1;
                    lblGas.Text = myCar.Tank.ToString();
                    lblMph.Text = myCar.Speed.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
