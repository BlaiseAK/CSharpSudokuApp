using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double orderTotal = 0.00;
            double smallPizzaSize = 10.00;
            double mediumPizzaSize = 13.00;
            double largePizzaSize = 16.00;
            double deepDish = 2.00;
            double pepperoni = 1.50;
            double onions = .75;
            double greenPeppers = .5;
            double redPeppers = .75;
            double anchovies = 2.00;

            if (!pizzaSizeRadioButton1.Checked && !pizzaSizeRadioButton2.Checked && !pizzaSizeRadioButton3.Checked)
            {
                System.Windows.Forms.MessageBox.Show("Please select one of the sizes");
            }
            else if (pizzaSizeRadioButton1.Checked)
            {
                orderTotal += smallPizzaSize;
            }
            else if (pizzaSizeRadioButton2.Checked)
            {
                orderTotal += mediumPizzaSize;
            }
            else if (pizzaSizeRadioButton3.Checked)
            {
                orderTotal += largePizzaSize;
            }

            if (!crustTypeRadioButton1.Checked && !crustTypeRadioButton2.Checked)
            {
                System.Windows.Forms.MessageBox.Show("Please select a crust type!");
            }
            else if (crustTypeRadioButton2.Checked)
            {
                orderTotal += deepDish;
            }

            if (pepperoniCheckBox.Checked)
            {
                orderTotal += pepperoni;
            }

            if (onionsCheckBox.Checked)
            {
                orderTotal += onions;
            }

            if (greenPeppersCheckBox.Checked)
            {
                orderTotal += greenPeppers;
            }

            if (redPeppersCheckBox.Checked)
            {
                orderTotal += redPeppers;
            }

            if (anchoviesCheckBox.Checked)
            {
                orderTotal += anchovies;
            }

            if ((pepperoniCheckBox.Checked && greenPeppersCheckBox.Checked && anchoviesCheckBox.Checked) || (pepperoniCheckBox.Checked && redPeppersCheckBox.Checked && onionsCheckBox.Checked))
            {
                orderTotal -= 2;
            }

            orderTotalLabel.Text = "$" + orderTotal;
        }
    }
}