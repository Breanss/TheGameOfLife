
namespace GameOfLife
{
    internal class Tools
    {
        public int countAliveNeighbours(int x, int y, bool[,] tab)
        {
            int count = 0;
            if(x-1>=0 && y-1>=0)
                if (tab[x - 1, y - 1]) count++;
            if(y-1>=0)
                if (tab[x, y - 1]) count++;
            if(y-1>=0 && x + 1 < tab.GetLength(0))
                if (tab[x + 1, y - 1]) count++;
            if(x-1>=0)
                if (tab[x - 1, y]) count++;
            if(x + 1 < tab.GetLength(0))
                if (tab[x + 1, y]) count++;
            if(x-1>=0 && y+1< tab.GetLength(1))
                if (tab[x - 1, y + 1]) count++;
            if(y + 1 < tab.GetLength(1))
                if (tab[x, y + 1]) count++;
            if(y + 1 < tab.GetLength(1) && x + 1 < tab.GetLength(0))
                if (tab[x + 1, y + 1])count++;
            
            return count;
        }


        public string tabToString(bool[,] tab)
        {
            string text="";
            for(int i=0; i<tab.GetLength(0); i++)
            {
                for(int j=0; j<tab.GetLength(1); j++)
                {
                    if (tab[i, j] == true)
                    {
                        text = text + ""+i+":"+j+"\n";
                    }
                }
            }
            
            return text;
        }
    }
}
