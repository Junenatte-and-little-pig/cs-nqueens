using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace nqueens
{
    class clsFile
    {
        clsBoard board;
        public clsFile(clsBoard board)
        {
            this.board = board;
        }
        public bool isEmptyFile(string path)
        {
            bool flag = false;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            if (fs.Length == 0)
                flag = true;
            fs.Close();
            return flag;
        }
        public List<Button> loadData(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<Button> btns = board.Btns;
            for (int i = 0; i < btns.Count; i++)
            {
                string s = sr.ReadLine();
                string[] ss = s.Split('\t');
                btns[i].Text = ss[1];
                btns[i].ForeColor = ColorTranslator.FromHtml(ss[2]);
                btns[i].BackColor = ColorTranslator.FromHtml(ss[3]);
            }
            return btns;
        }
        public void saveData(string path)
        {
            bool flag = true;
            if (!isEmptyFile(path))
            {
                DialogResult dr = MessageBox.Show("将覆盖之前的游戏数据，确定继续吗？", "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                    flag = false;
            }
            if (flag)
            {
                StreamWriter sw = new StreamWriter(path, false);
                String str;
                List<Button> btns = board.Btns;
                for (int i = 0; i < btns.Count; i++)
                {
                    str = btns[i].Name + '\t'
                        + btns[i].Text + '\t'
                        + ColorTranslator.ToHtml(btns[i].ForeColor) + '\t'
                        + ColorTranslator.ToHtml(btns[i].BackColor) + '\r' + '\n';
                    sw.Write(str);
                }
                sw.Close();
            }
        }
    }
}
