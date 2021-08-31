using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KangarooMovement
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            string inputVal = inputTextBox.Text;
            int distance = int.Parse(inputVal);

            int hop = 3;

            for (int x = distance; x >= 0; x-=hop)
            {
                int numHop = x / hop;
                int numStep = distance - (numHop * hop);

                resultLabel.Text += distance + " meters = " + numHop + " hops and " + numStep + " steps <br />";
            }
        }
    }
}