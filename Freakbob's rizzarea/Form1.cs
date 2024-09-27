using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freakbob_s_rizzarea
{
    public partial class form1 : Form
    {
        double skibidiSlicersPrice;
        double geekedBajaBlastPrice;
        double nettspendNuggetsPrice;
        double skibidiSlicersNumber;
        double geekedBajaBlastNumber;
        double nettspendNuggetsNumber;
        double subtotal;
        double total;
        double tendred;
        double change;
        double tax;
        double skibidiSlicersVari;
        double geekedBajaBlastVari;
        double nettspendNuggetsVari;

        


        public form1()
        {
            InitializeComponent();
        }

        private void CalculateTotals_Click(object sender, EventArgs e)
        {

            try
            {
                errorOutput.Text = "FreakBob's Rizzarea";

                skibidiSlicersPrice = 2.55;
                geekedBajaBlastPrice = 4.50;
                nettspendNuggetsPrice = 3.40;
                skibidiSlicersNumber = Convert.ToDouble(SkibidiSlicersTextBox.Text);
                geekedBajaBlastNumber = Convert.ToDouble(GeekedBajaBlastTexBox.Text);
                nettspendNuggetsNumber = Convert.ToDouble(NettspendNuggetsTextBox.Text);
                skibidiSlicersVari = skibidiSlicersPrice * skibidiSlicersNumber;
                geekedBajaBlastVari =  geekedBajaBlastPrice * geekedBajaBlastNumber;
                nettspendNuggetsVari =  nettspendNuggetsPrice * nettspendNuggetsNumber;

                subtotal = skibidiSlicersVari + geekedBajaBlastVari + nettspendNuggetsVari;
                tax = subtotal * .13;
                total = subtotal + tax;

                SubTotalText.Text = $"{subtotal.ToString("C")}";

                TaxText.Text = $"{tax.ToString("C")}";

                TotalText.Text = $"{total.ToString("C")}";

                CalulateButton.Enabled = true;

            }

            catch
            {
                errorOutput.Text = "Error Error Error Error Error Error Input Number";
                errorOutput.Visible = true;


            }



        }

        private void CalulateButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorOutput.Text = "";
                errorOutput.Visible = false;
                tendred = Convert.ToDouble(tendredInput);

                change = tendred - total;
                ChangeLabel.Text = $"{change.ToString("C")}";

                printRecepit.Enabled = true;


            }
            catch 
            {
                errorOutput.Text = "Error Error Error Error Error Error Input Number";
                errorOutput.Visible = true;
            }
        }

        private void printRecepit_Click(object sender, EventArgs e)
        {

        }
    }
}
