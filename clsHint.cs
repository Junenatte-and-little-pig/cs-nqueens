using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace nqueens
{
    class clsHint
    {
        clsJudge judge;
        public clsHint(clsGame gg)
        {
            judge = new clsJudge(gg);
        }
        public void changeColor(Button b, Color afterColor)
        {
            if (judge.foreOrBack(b, Color.Black) == 1)
                b.BackColor = afterColor;
            else if (judge.foreOrBack(b, Color.Black) == -1)
                b.ForeColor = afterColor;
        }
        public void changeColor(Button b, Color beforeColor, Color afterColor)
        {
            if (judge.foreOrBack(b, beforeColor) == 1)
                b.ForeColor = afterColor;
            else if (judge.foreOrBack(b, beforeColor) == -1)
                b.BackColor = afterColor;
        }
        public void errorHint(Button b)
        {
            if (judge.isError(b))
                changeColor(b, Color.Red);
            else
                changeColor(b, Color.Red, Color.White);
        }
        public void greenHint(List<Button> btns)
        {
            for (int i = 0; i < btns.Count; i++)
                if (!judge.isError(btns[i]))
                    changeColor(btns[i], Color.Green);
                else
                    changeColor(btns[i], Color.White);
        }
        public void clearHint(List<Button> btns)
        {
            for (int i = 0; i < btns.Count; i++)
                changeColor(btns[i], Color.White);
        }
    }
}
