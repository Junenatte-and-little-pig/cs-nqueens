using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace nqueens
{
    class clsGame : clsBoard
    {
        bool isstarted;
        int step;
        ToolStripMenuItem item = new ToolStripMenuItem();
        public clsGame(ToolStripMenuItem mh, int r,Form frm) : base(r,frm)
        {
            item = mh;
            step = r;
        }
        public bool isStarted
        {
            get { return isstarted; }
            set { isstarted = value; }
        }
        public int Step
        {
            get { return step; }
            set { step = value; }
        }
        public ToolStripMenuItem Item
        {
            get { return item; }
            set { item = value; }
        }
        public void SetQueen(Button b)
        {
            b.Text = "queen";
            if (b.BackColor == Color.Black)
                b.ForeColor = Color.White;
            else if (b.ForeColor == Color.Black)
                b.ForeColor = Color.Black;
        }
        public void InitQueen(Button b)
        {
            b.Text = "O";
            if (b.BackColor == Color.Black)
                b.ForeColor = Color.White;
            else if (b.ForeColor == Color.Black)
                b.BackColor = Color.White;
        }
        public void Fresh()
        {
            clsJudge judge = new clsJudge(this);
            clsHint hint = new clsHint(this);
            if (item.Checked)
            {
                hint.greenHint(Btns);
                if (Done != null)
                    for (int i = 0; i < Done.Count; i++)
                        hint.errorHint(Done[i]);
            }
            else
                hint.clearHint(Btns);
        }
        public bool isIn(List<Button> done, Button b)
        {
            bool flag = false;
            for (int i = 0; i < done.Count; i++)
                if (done[i].Name == b.Name)
                    flag = true;
            return flag;
        }
        public bool isWin()
        {
            clsJudge judge = new clsJudge(this);
            bool flag = true;
            if (step != 0)
                flag = false;
            else
                for (int i = 0; i < Done.Count; i++)
                    if (judge.isError(Done[i]))
                        flag = false;
            return flag;
        }
        public void isSuccess()
        {
            DialogResult dr;
            if (Step == 0)
                if (isWin())
                    dr = MessageBox.Show("恭喜你，游戏成功！", "游戏结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    dr = MessageBox.Show("游戏失败！", "游戏结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void menuInit(int moveCount,ToolStripMenuItem MenuUndo,ToolStripMenuItem MenuSave)
        {
            if (moveCount <= 0)
                isStarted = false;
            if (!isStarted)
            {
                MenuUndo.Enabled = false;
                MenuSave.Enabled = false;
            }
            else
            {
                MenuUndo.Enabled = true;
                MenuSave.Enabled = true;
            }

        }
    }
}
