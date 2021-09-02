﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            comparisonTypeLabel.Text = "equal to";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = ""; //clearing text

            if(checkedCheckBox.Checked && firstTextBox.Text == "Bob" && secondTextBox.Text == "Tabor")
            {
                resultLabel.Text = "Perfect Trifecta!";
            }
        }
    }
}