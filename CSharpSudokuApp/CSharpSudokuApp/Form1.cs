using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSudokuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createRadioBtns();
        }

        public int activeNumber = 0;
        
        private void radioBtn_CheckedChanged(Object sender, EventArgs e)
        {
            RadioButton rBtn = sender as RadioButton;
            activeNumber = int.Parse(rBtn.Text);
        }

        public void createRadioBtns()
        {
            for (int i = 1; i <= 9; i++)
            {
                RadioButton rBtn = new RadioButton()
                {
                    Text = $"{i}",
                    Font = new Font(FontFamily.GenericSansSerif, 15),
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Name = $"RadioBtn{i}",
                    Left = (i * 40),
                    Top = 70,
                    Size = new System.Drawing.Size(35, 40)
                };
                rBtn.CheckedChanged += radioBtn_CheckedChanged;
                splitContainer1.Panel2.Controls.Add(rBtn);
            }
        }
    }
}
