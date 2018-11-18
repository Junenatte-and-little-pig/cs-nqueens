using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace nqueens
{
    class clsJudge
    {
        clsGame gg;
        List<Button> btns;
        public clsJudge(clsGame gg)
        {
            this.gg = gg;
            btns = gg.Btns;
        }
        public bool inSameRow(Button b1, Button b2)
        {
            return b1.Name.Split(' ')[0] == b2.Name.Split(' ')[0] && b1.Name != b2.Name;
        }
        public bool inSameCol(Button b1, Button b2)
        {
            return b1.Name.Split(' ')[1] == b2.Name.Split(' ')[1] && b1.Name != b2.Name;
        }
        public bool inSameLeftDiagonal(Button b1, Button b2)
        {
            int gap1 = int.Parse(b1.Name.Split(' ')[0]) - int.Parse(b1.Name.Split(' ')[1]);
            int gap2 = int.Parse(b2.Name.Split(' ')[0]) - int.Parse(b2.Name.Split(' ')[1]);
            return gap1 == gap2 && b1.Name != b2.Name;
        }
        public bool inSameRightDiagonal(Button b1, Button b2)
        {
            int sum1 = int.Parse(b1.Name.Split(' ')[0]) + int.Parse(b1.Name.Split(' ')[1]);
            int sum2 = int.Parse(b2.Name.Split(' ')[0]) + int.Parse(b2.Name.Split(' ')[1]);
            return sum1 == sum2 && b1.Name != b2.Name;
        }
        public bool isError(Button b)
        {
            bool flag = false;
            for (int i = 0; i < gg.Done.Count; i++)
                if (inSameRow(gg.Done[i], b) ||
                    inSameCol(gg.Done[i], b) ||
                    inSameLeftDiagonal(gg.Done[i], b) ||
                    inSameRightDiagonal(gg.Done[i], b))
                    flag = true;
            return flag;
        }
        public int foreOrBack(Button b, Color color)
        {
            int flag = 0;
            if (b.ForeColor == color)
                flag = 1;
            else if (b.BackColor == color)
                flag = -1;
            return flag;
        }
    }
}
