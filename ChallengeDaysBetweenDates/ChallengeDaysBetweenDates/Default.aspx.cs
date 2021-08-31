using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultsLabel.Text = "";

            DateTime firstDate = Calendar1.SelectedDate;
            DateTime secondDate = Calendar2.SelectedDate;

            if (firstDate>secondDate)
            {
                TimeSpan daysBetween = firstDate.Subtract(secondDate);
                resultsLabel.Text = daysBetween.TotalDays.ToString();
            }
            else
            {
                TimeSpan daysBetween = secondDate.Subtract(firstDate);
                resultsLabel.Text = daysBetween.TotalDays.ToString();
            }
        }
    }
}