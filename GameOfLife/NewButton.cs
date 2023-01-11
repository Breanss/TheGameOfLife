using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class NewButton
    {
        Panel mainPanel;
        Board plansza;

        public NewButton(Panel mainPanel, Board plansza)
        {
            this.mainPanel = mainPanel;
            this.plansza = plansza;
        }

        public void addButton(int i, int j, int size)
        {
            Button b = new Button();
            b.Location = new Point(i * size, j * size);
            b.Size = new Size(size, size);
            b.TabIndex = 0;
            b.Click += new System.EventHandler(this.cell_Click);
            b.Tag = new Point(i, j);
            b.Name = new Point(i, j).ToString();
            b.BackColor = Color.FromArgb(-4670026);
            mainPanel.Controls.Add(b);
        }

        private void cell_Click(object sender, EventArgs e)
        {
            Button b = (sender as Button);
            if (b.BackColor == Color.FromArgb(-4670026))
            {
                Point p =(Point) b.Tag;
                plansza.setCells(p.X,p.Y,true);
                b.BackColor = Color.FromArgb(-1410546);
            }
            else
            {
                Point p = (Point)b.Tag;
                plansza.setCells(p.X, p.Y, false);
                b.BackColor = Color.FromArgb(-4670026); 
            }
        }
    }
}
