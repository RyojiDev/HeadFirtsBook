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
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, chkOpcaoSaudavel.Checked, chkDecoracaoChique.Checked);
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)numberOfPeapleB.Value,
                chkChic.Checked, txtCakeWriting.Text);
            DisplayBirthdayPartCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(chkChic.Checked);
            lblCostLabel.Text = Cost.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void DisplayBirthdayPartCost()
        {
            birthdayParty.CakeWriting = txtCakeWriting.Text;
            decimal cost = birthdayParty.CalculateCost();
            lblTotalValue.Text = cost.ToString("c");
        }

        private void numberOfPeapleB_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberOfPeapleB.Value;
            DisplayBirthdayPartCost();
        }

        private void chkChic_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(chkChic.Checked);
            DisplayBirthdayPartCost();
        }

        private void chkWriteonCake_CheckedChanged(object sender, EventArgs e)
        {
            txtCakeWriting.Visible = true;
            DisplayBirthdayPartCost();
        }
    }
}
