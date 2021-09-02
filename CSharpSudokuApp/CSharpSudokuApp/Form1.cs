using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpSudokuApp.Model;

namespace CSharpSudokuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createRadioBtns();
            createSudokuButtons();
        }

        public int activeNumber = 0;

        public void createSudokuButtons()
        {
            for (int r = 1; r <= 9; r++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    Button sBtn = new Button()
                    {
                        Font = new Font(FontFamily.GenericSansSerif, 15),
                        ForeColor = Color.Black,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Name = $"r{r}c{c}",
                        Size = new Size(30, 30),
                        Top = (r * 40),
                        Left = (c * 40),
                        Tag = new ButtonTagData(c, r)
                    };
                    sBtn.Click += sBtn_Click;
                    splitContainer1.Panel1.Controls.Add(sBtn);
                }
            }
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

        private void sBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = activeNumber.ToString();
            ButtonTagData newTagData = (ButtonTagData) btn.Tag;
            newTagData.Value = activeNumber;
            Console.WriteLine($"C{newTagData.XPos}R{newTagData.YPos}");
        }

        private void radioBtn_CheckedChanged(Object sender, EventArgs e)
        {
            RadioButton rBtn = sender as RadioButton;
            activeNumber = int.Parse(rBtn.Text);
        }
    }
}
