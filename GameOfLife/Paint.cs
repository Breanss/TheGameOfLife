using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class Paint
    {
        public void paintFromTab(bool[,] tab, Panel panel)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] == true)
                    {
                        Point tag = new Point(i, j);
                        foreach (Control p in panel.Controls)
                        {
                            Point point = (Point)p.Tag;
                            if (point == tag)
                            {
                                p.BackColor = Color.FromArgb(-1410546);
                            }
                        }
                    }
                   
                    else
                    {
                        Point tag = new Point(i, j);
                        foreach (Control p in panel.Controls)
                        {
                            Point point = (Point)p.Tag;
                            if (point == tag)
                            {
                                p.BackColor = Color.FromArgb(-4670026);
                            }
                        }
                    }
                }
            }
        }
    }
}
