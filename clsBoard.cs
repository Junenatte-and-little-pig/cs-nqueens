using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace nqueens
{
    class clsBoard
    {
        int bound;
        int range;
        Point start;
        Point btnSize;
        List<Button> btns = new List<Button>();
        List<Button> done = new List<Button>();
        public clsBoard(int r, Form frm)
        {
            range = r;
            bound = frm.Height > frm.Width ? (frm.Width > 300 ? frm.Width : 300) : (frm.Height > 300 ? frm.Height : 300);
            start = new Point(bound *3 / ((range + 4)*2), bound * 3 / ((range + 4)*2));
            btnSize = new Point(bound / (range + 4), bound / (range + 4));
            CreateButtons(range);
        }
        public List<Button> Btns
        {
            get { return btns; }
            set { btns = value; }
        }
        public List<Button> Done
        {
            get { return done; }
            set { done = value; }
        }
        public Button CreateButton()
        {
            Button btn = new Button
            {
                Size = new Size(btnSize),
                Text = "O"
            };
            return btn;
        }
        public List<Button> CreateButtons(int r)
        {
            for (int i = 0; i < range; i++)
                for (int j = 0; j < range; j++)
                {
                    btns.Add(CreateButton());
                    btns[i * range + j].Location = new Point(start.X + j * bound / (range + 4), start.Y + i * bound / (range + 4));
                    btns[i * range + j].Name = i + " " + j;
                    if ((i % 2 + j % 2) % 2 == 0)
                    {
                        btns[i * r + j].BackColor = Color.Black;
                        btns[i * r + j].ForeColor = Color.White;
                    }
                    else
                    {
                        btns[i * r + j].BackColor = Color.White;
                        btns[i * r + j].ForeColor = Color.Black;
                    }
                }
            return btns;
        }
        public void AppendForm(Form frm)
        {
            frm.SuspendLayout();
            for (int i = 0; i < btns.Count; i++)
                frm.Controls.Add(btns[i]);
            frm.ResumeLayout(false);
            frm.PerformLayout();
        }
        public void RemoveForm(Form frm)
        {
            frm.SuspendLayout();
            if (btns != null)
                for (int i = 0; i < btns.Count; i++)
                {
                    frm.Controls.Remove(btns[i]);
                    btns[i].Dispose();
                }
            frm.ResumeLayout(false);
            frm.PerformLayout();
        }
        public void changeSize(Form frm)
        {
            bound = frm.Height > frm.Width ? (frm.Width > 300 ? frm.Width : 300) : (frm.Height > 300 ? frm.Height : 300);
            start = new Point(bound * 3 / ((range + 4) * 2), bound * 3 / ((range + 4) * 2));
            btnSize = new Point(bound / (range + 4), bound / (range + 4));
            for(int i = 0; i < range; i++)
            {
                for (int j = 0; j < range; j++)
                {
                    btns[i * range + j].Size = new Size(bound / (range + 4), bound / (range + 4));
                    btns[i * range + j].Location = new Point(start.X + j * bound / (range + 4), start.Y + i * bound / (range + 4));
                }
            }
        }
    }
}
