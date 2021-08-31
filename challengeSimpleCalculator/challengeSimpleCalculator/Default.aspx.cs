using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace challengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string firstString = firstTextBox.Text; //Stores the 1st string
            int firstValue = int.Parse(firstString); //Changes string to int datatype

            string secondString = secondTextBox.Text; //Stores the 2nd string
            int secondValue = int.Parse(secondString); //Changes string to int datatype

            int result = firstValue + secondValue; //Math Operation performed

            resultLabel.Text = result.ToString(); //Changes result datatype to a string
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            string firstString = firstTextBox.Text; //Stores the 1st string
            int firstValue = int.Parse(firstString); //Changes string to int datatype

            string secondString = secondTextBox.Text; //Stores the 2nd string
            int secondValue = int.Parse(secondString); //Changes string to int datatype

            int result = firstValue - secondValue; //Math Operation performed

            resultLabel.Text = result.ToString(); //Changes result datatype to a string
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            string firstString = firstTextBox.Text; //Stores the 1st string
            int firstValue = int.Parse(firstString); //Changes string to int datatype

            string secondString = secondTextBox.Text; //Stores the 2nd string
            int secondValue = int.Parse(secondString); //Changes string to int datatype

            int result = firstValue * secondValue; //Math Operation performed

            resultLabel.Text = result.ToString(); //Changes result datatype to a string
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            string firstString = firstTextBox.Text; //Stores the 1st string
            int firstValue = int.Parse(firstString); //Changes string to int datatype

            string secondString = secondTextBox.Text; //Stores the 2nd string
            int secondValue = int.Parse(secondString); //Changes string to int datatype

            int result = firstValue / secondValue; //Math Operation performed

            resultLabel.Text = result.ToString(); //Changes result datatype to a string
        }
    }
}