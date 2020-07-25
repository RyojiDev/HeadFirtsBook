using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiveTakeCashGuy.O.O
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joeCash.Text = joe.Nome + "tem $" + joe.Cash;
            bobCash.Text = bob.Nome + "tem $" + bob.Cash;
            bankCash.Text = "o banco tem $ " + bank;
        }


        public Form1()
        {

            InitializeComponent();
            joe = new Guy()
            {
                Nome = "Joe",
                Cash = 100
            };


            bob = new Guy();
            bob.Nome = "Bob";
            bob.Cash = 50;

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("O banco está sem dinheiro. ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void joeCash_Click(object sender, EventArgs e)
        {

        }

        private void bobCash_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bankCash_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }
    }
}
