using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LacosVarCap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("nome é" + name
                + "\nx is" + x
                + "\nd is" + d);
        }

        private void button2_Click(object sender,EventArgs e)
        {
            int x = 5;
            if(x == 10)
            {
                MessageBox.Show("x necessita ser 10");
            }
            else
            {
                MessageBox.Show("x não é 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            string name = "Bobbo jr.";

            if((someValue < 3) && (name.Equals("joe")))
            {
                MessageBox.Show("x é 3 e o nome é Joe");
            }
            else
            {
                MessageBox.Show("essa linha executa em qualquer caso");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while(count < 10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            MessageBox.Show("O resultado é " + count);
        }
    }
}
