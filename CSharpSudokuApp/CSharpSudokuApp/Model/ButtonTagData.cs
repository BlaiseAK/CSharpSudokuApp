using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSudokuApp.Model
{
    public class ButtonTagData
    {
        public int XPos { get; }
        public int YPos { get; }

        public int Value { get; set; }

        public ButtonTagData()
        {
            XPos = 0;
            YPos = 0;
        }

        public ButtonTagData(int x, int y)
        {
            XPos = x;
            YPos = y;
        }

        public ButtonTagData(int x, int y, int val)
        {
            XPos = x;
            YPos = y;
            Value = val;
        }
    }
}
