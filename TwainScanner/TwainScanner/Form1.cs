using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saraff.Twain;

namespace TwainScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Twain32 _twain = new Twain32();

        private void acquireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _twain.Acquire();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SAMPLE1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _twain.SelectSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SAMPLE2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
