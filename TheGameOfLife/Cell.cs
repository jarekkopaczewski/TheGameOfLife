using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    class Cell
    {
        private int numberOfBorderer;
        private bool isAlive;

        public Cell(Random rnd)
        {
            int temp = rnd.Next(2);

            if (temp == 1)
                isAlive = true;
            else
                isAlive = false;
        }

        public bool CellStatus()
        {
            return this.isAlive;
        }

        public bool CellSeter
        {
            get => isAlive;
            set
            {
                if (value == true || value == false)
                    isAlive = value;
            }
        }

        public int SetBorderer
        {
            get => numberOfBorderer;
            set
            {
                if( (value >= 0) && (value <= 9))
                {
                    numberOfBorderer = value;
                }
            }
        }

        public int ShowBorderer()
        {
            return numberOfBorderer;
        }

        public void IncreaseIfBordererAlive( Cell cell )
        {
            if (cell.isAlive == true)
                this.numberOfBorderer++;
        }
    }
}
