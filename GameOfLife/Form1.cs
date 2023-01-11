using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Board _plansza;
        private Board _planszaStart;
        private NewButton newButton;
        System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void plansza10x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aTimer != null) aTimer.Stop();
            this._plansza = new Board(BoardSize.small);

            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            this.mainPanel.Controls.Clear();

            int panelWidth = this.mainPanel.Width;
            int panelHeight = this.mainPanel.Height;

            int size = panelWidth / 10 < panelHeight / 10 ? panelWidth / 10 : panelHeight / 10;

            newButton = new NewButton(mainPanel, _plansza);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    newButton.addButton(i, j, size);
                }

            }
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
      
        private void plansza10x15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aTimer != null) aTimer.Stop();
            this._plansza = new Board(BoardSize.med);

            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            this.mainPanel.Controls.Clear();
            int panelWidth = this.mainPanel.Width;
            int panelHeight = this.mainPanel.Height;
            int size = panelWidth / 10 < panelHeight / 15 ? panelWidth / 10 : panelHeight / 15;

            newButton = new NewButton(mainPanel, _plansza);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    newButton.addButton(i, j, size);
                }
            }

           this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void plansza15x15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(aTimer!=null) aTimer.Stop();

            this._plansza = new Board(BoardSize.large);

            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            this.mainPanel.Controls.Clear();
            int panelWidth = this.mainPanel.Width;
            int panelHeight = this.mainPanel.Height;
            int size = panelWidth / 15 < panelHeight / 15 ? panelWidth / 15 : panelHeight / 15;
            newButton = new NewButton(mainPanel, _plansza);

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    newButton.addButton(i, j, size);
                }
            }
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void plansza20x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aTimer != null) aTimer.Stop();

            this._plansza = new Board(BoardSize.extralarge);

            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            this.mainPanel.Controls.Clear();
            int panelWidth = this.mainPanel.Width;
            int panelHeight = this.mainPanel.Height;
            int size = panelWidth / 20 < panelHeight / 10 ? panelWidth / 20 : panelHeight / 10;
            newButton = new NewButton(mainPanel, _plansza);

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    newButton.addButton(i, j, size);
                }
            }
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aTimer != null) aTimer.Stop();
            bool error = false;
            int maxY = 0;
            int maxX = 0;
            string[] tekst;
            List<Point> points = new List<Point>();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tekst = File.ReadAllLines(openFileDialog.FileName);
                    foreach (string s in tekst)
                    {
                        string[] tmp = s.Split(':');

                        if (tmp.Length != 2)
                        {
                            error = true;
                            break;
                        }

                        if (Convert.ToInt32(tmp[0]) > maxX)
                        {
                            maxX = Convert.ToInt32(tmp[0]);
                        }
                        if (Convert.ToInt32(tmp[1]) > maxY)
                        {
                            maxY = Convert.ToInt32(tmp[1]);
                        }

                        Point p = new Point(Convert.ToInt32(tmp[0]), Convert.ToInt32(tmp[1]));
                        points.Add(p);
                    }


                    if ((maxX > 19 && maxY > 14) || error == true)
                    {
                        error = true;
                        MessageBox.Show("Błędne dane w pliku", "info", MessageBoxButtons.OK);
                    }
                    else if (maxX > 9 && maxX<14)
                    {
                        plansza15x15ToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Wczytano plik", "info", MessageBoxButtons.OK);
                    }
                    else if (maxY > 9)
                    {
                        plansza10x15ToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Wczytano plik", "info", MessageBoxButtons.OK);
                    }else if (maxX > 14) 
                     {
                        plansza20x10ToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Wczytano plik", "info", MessageBoxButtons.OK);
                    } 
                    else
                    {
                        plansza10x10ToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Wczytano plik", "info", MessageBoxButtons.OK);
                    }
                    if (error == false)
                    {
                        foreach (Point p in points)
                        {
                            _plansza.setCells(p.X, p.Y, true);
                            _plansza.setCells(p.X, p.Y, true);
                        }

                        new Paint().paintFromTab(_plansza.getCells(), mainPanel);      
                    }
                }
            }

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_planszaStart == null) { _planszaStart = new Board(_plansza.getSize()); _planszaStart.setCellsTab(_plansza.getCells()); };
            Tools tools = new Tools();
            Paint paint= new Paint();
            Boolean[,] cells = _plansza.getCells();
            int szerokosc = cells.GetLength(0);
            int dlugosc = cells.GetLength(1);
            Boolean[,] newCells = new Boolean[szerokosc, dlugosc];
            for (int y = 0; y < dlugosc; y++)
            {
                for (int x = 0; x < szerokosc; x++)
                {
                    int aliveNeighbours = tools.countAliveNeighbours(x, y, cells);

                    if (cells[x, y] == false && aliveNeighbours == 3)
                    {
                        newCells[x, y] = true;
                    }
                    if (cells[x,y]==true&&(aliveNeighbours==2 || aliveNeighbours == 3))
                    {
                        newCells[x,y] = true;
                    }
                }
            }
            _plansza.setCellsTab(newCells);
            paint.paintFromTab(newCells, mainPanel);
           
        }

        private void startTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(startToolStripMenuItem_Click);
            aTimer.Interval = 500;
            aTimer.Enabled = true;
        }

        private void stopTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aTimer != null) aTimer.Stop();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paint paint = new Paint();
            if (_planszaStart != null) {
                _plansza.setCellsTab(_planszaStart.getCells());
                _planszaStart= null;
                paint.paintFromTab(_plansza.getCells(), mainPanel);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            Tools tools = new Tools();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.DefaultExt="txt";

            if (_plansza!=null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = new StreamWriter(saveFileDialog.OpenFile())) != null)
                    {
                        String text;
                        if(_planszaStart!=null)
                        {
                            text = tools.tabToString(_planszaStart.getCells());
                        }
                        else
                        {
                            text = tools.tabToString(_plansza.getCells());
                        }
                        myStream.Write(text);
                        myStream.Dispose();
                        myStream.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak planszy!", "info", MessageBoxButtons.OK);
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            if(aTimer!=null) aTimer.Stop();
            _planszaStart= null;
            _plansza = null;
        }

        
    }
}
