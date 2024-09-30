using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
        double order;
        

        


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
                
            }
        }

        private void printRecepit_Click(object sender, EventArgs e)
        {
            order = (Convert.ToDouble(orderNameText));

            skibidiSlicersFInal.Text = $"X{skibidiSlicersNumber} = {skibidiSlicersVari.ToString("C")}";
            skibidiSlicersFInal.Visible = true;
            skibidiSlicers1.Visible = true;

            Thread.Sleep(1000);


            geekedBajaBlastFinal.Text = $"X{geekedBajaBlastNumber} = {geekedBajaBlastVari.ToString("C")}";
            geekedBajaBlastFinal.Visible = true;
            geekedBajaBlast1.Visible = true;

            Thread.Sleep(1000);

            nettspendNuggetsFinal.Text = $"X{nettspendNuggetsNumber} = {nettspendNuggetsVari.ToString("C")}";
            nettspendNuggetsFinal.Visible = true;
            nettspendNuggets1.Visible = true;

            Thread.Sleep(1000);

            subTotal1.Visible = true;
            subTotalFinal.Visible = true;
            subTotalFinal.Text = $"{subtotal.ToString("C")}";

            Thread.Sleep(1000);

            tax1.Visible = true;
            taxFinal.Visible = true;    
            taxFinal.Text = $"{tax.ToString("C")}";

            Thread.Sleep(1000);

            totalFinal.Visible = true;
            total1.Visible = true;
            totalFinal.Text = $"{total.ToString("C")}";

            Thread.Sleep(1000);

            tendredFinal.Text = $"{tendred.ToString("C")}";
            tendredFinal.Visible = true;
            tendred1.Visible = true;











        }
    }
}
