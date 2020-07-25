using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorDeQuilometragem
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;
        int final;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numKmInicial.Value;
            endingMileage = (int)numKmFinal.Value;
            if (startingMileage > endingMileage)
            {
                MessageBox.Show("A quilometragem inicial deve ser menor que a quilometragem inicial", "ImpossivelCalular");
            }
            else
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                lblResult.Text = "$" + amountOwed;
            }
        }

        private void btnMostraKm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResult.Text))
            {
                final = (int)numKmFinal.Value - (int)numKmInicial.Value;
                lblKM.Text = $"{milesTraveled} km";
            }
            else
            {
                lblKM.Text = "";
            }

        }
    }
}
