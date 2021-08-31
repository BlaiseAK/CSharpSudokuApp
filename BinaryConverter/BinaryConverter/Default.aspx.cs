using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BinaryConverter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void convertButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";

            string inputVal = inputTextBox.Text;
            int value = int.Parse(inputVal);

            string binary = Convert.ToString(value, 2);

            int count = binary.Split('1').Length - 1;

            resultLabel.Text = value + " decimal converts to " + binary + " binary and has " + count + ", 1 bits.";

        }
    }
}