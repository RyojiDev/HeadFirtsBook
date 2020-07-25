using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatarinaFestas
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
           
           

        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(chkChic.Checked);
            lblCostLabel.Text = Cost.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CarregarTab_load(object sender, EventArgs e)
        {
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, chkOpcaoSaudavel.Checked, chkDecoracaoChique.Checked);
            dinnerParty.SetNumberOfPeople(5);
            dinnerParty.CalculateCostOfDecorations(chkDecoracaoChique.Checked);
            dinnerParty.SetHealthOption(chkOpcaoSaudavel.Checked);
            DisplayDinnerPartyCost();
        }

        private void Tbc_Load(object sender, EventArgs e)
        {
            if (numberOfPeaple.Value > 0 || chkNormal.Checked || chkChic.Checked)
            {
                if (chkWriteonCake.Checked)
                {
                    numberWords.Visible = true;
                }
                if (chkNormal.Checked || chkChic.Checked)
                {
                    BirthdayParty birthday = new BirthdayParty();
                    if (chkNormal.Checked)
                    {
                        if (chkChic.Checked == false) 
                        { 
                        lblRateValue.Visible = true;
                        lblRateValue.Text = "30,00 R$";
                        birthday.NumberOfPeople = (int)numberOfPeaple.Value;
                        birthday.CalculateCostOfDecorations(Convert.ToDecimal(lblNormal.Text.Replace("R$","")),Convert.ToDecimal(lblRateValue.Text.Replace("R$","")));
                        lblTotalValue.Visible = true;
                        lblTotalValue.Text = birthday.CalculateCost((int)numberWords.Value);
                        
                        }
                    }
                    else if(chkChic.Checked)
                    {
                        chkNormal.Checked = false;
                        lblRateValue.Visible = true;
                        lblRateValue.Text = "50,00 R$";
                        birthday.NumberOfPeople = (int)numberOfPeaple.Value;
                        birthday.CalculateCostOfDecorations(Convert.ToDecimal(lblChic.Text.Replace("R$", "")), Convert.ToDecimal(lblRateValue.Text.Replace("R$", "")));
                        lblTotalValue.Visible = true;
                        lblTotalValue.Text = birthday.CalculateCost((int)numberWords.Value);
                    }
                    else
                    {
                        MessageBox.Show("Não tem opção marcada", "alerta");
                        Visible = false;
                    }
                }
               
            }
        }

        private void tbcDinnerParty_Click(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetNumberOfPeople((int)numericUpDown1.Value);
            DisplayDinnerPartyCost();
        }

        private void chkDecoracaoChique_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(chkDecoracaoChique.Checked);
            DisplayDinnerPartyCost();
        }

        private void chkOpcaoSaudavel_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthOption(chkOpcaoSaudavel.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
