using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_008
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //int i = 1;
            //int j = 2;
            //int result = i + j; //Addition

            //int i = 1;
            //int j = 2;
            //int result = i - j; //Subtraction

            //int i = 1;
            //int j = 2;
            //int result = i * j; //Multiplication

            int i = 1;
            int j = 2;
            int result = i / j; //Division

            resultLabel.Text = result.ToString();
        }
    }
}