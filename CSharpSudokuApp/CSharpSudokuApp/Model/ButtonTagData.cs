using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSudokuApp.Model
{
    class ButtonTagData
    {
        public int xPos { get; }
        public int yPos { get; }

        public int value { get; set; }

        ButtonTagData()
        {
            xPos = 0;
            yPos = 0;
        }

        ButtonTagData(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        ButtonTagData(int x, int y, int val)
        {
            xPos = x;
            yPos = y;
            value = val;
        }
    }
}
