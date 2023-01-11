using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public enum BoardSize
    {
        small = 1,
        med = 2,
        large = 3,
        extralarge=4,
    }
    internal class Board
    {
        private BoardSize _size;
        private bool[,] _cells;

        public Board(BoardSize size)
        {
            this._size = size;
            switch (this._size)
            {
                case BoardSize.small:
                    this._cells = new bool[10, 10];
                    break;
                case BoardSize.med:
                    this._cells = new bool[10, 15];
                    break;
                case BoardSize.large:
                    this._cells = new bool[15, 15];
                    break;
                case BoardSize.extralarge:
                    this._cells = new bool[20, 10];
                    break;
            }

        }

        public BoardSize getSize()
        {
            return _size;
        }

        public void setCells(int x, int y, bool value)
        {
            _cells[x, y] = value;
        }

        public void setCellsTab(Boolean[,] tab)
        {
            _cells = tab;
        }

        public bool[,] getCells()
        {
            return _cells;
        }

    }
}
