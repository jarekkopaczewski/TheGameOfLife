using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameOfLife
{
    class Planet
    {
        private int size;
        private int cellsAlive;
        private int cellsDead;
        private int generation;
        private Cell[,] planetMap;
        private Cell[,] planetMapCopy;
        private Random rnd = new Random();

        public Planet(int size)
        {
            this.size = size;
            planetMap = new Cell[size, size];
            planetMapCopy = new Cell[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    planetMap[i, j] = new Cell(rnd);
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    planetMapCopy[i, j] = new Cell(rnd);
                }
            }

            this.cellsAlive = 0;
            this.cellsDead = 0;
            this.generation = 0;
        }

        public void Generation()
        {
            this.cellsAlive = 0;
            this.cellsDead = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (planetMap[i, j].CellStatus() == true)
                    {
                        cellsAlive++;
                    }
                    else if (planetMap[i, j].CellStatus() == false)
                    {
                        cellsDead++;
                    }
                }
            }
            generation++;
        }

        public void Draw(PaintEventArgs e)
        {
            Graphics board = e.Graphics;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (planetMap[i, j].CellStatus() == true)
                    {
                        board.FillRectangle(Brushes.AntiqueWhite, 10 * i, 10 * j, 10, 10);
                    }
                    else
                    {
                        board.FillRectangle(Brushes.Black, 10 * i, 10 * j, 10, 10);
                    }
                }
            }
        }

        public void Cycle()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    planetMap[i, j].SetBorderer = 0;

                    if (i + 1 > size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[0, j]);
                    else if (i + 1 <= size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i + 1, j]);

                    if (j - 1 < 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i, size - 1]);
                    else if (j - 1 >= 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i, j - 1]);

                    if (j + 1 > size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i, 0]);
                    else if (j + 1 <= size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i, j + 1]);

                    if (i - 1 < 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[size - 1, j]);
                    else if (i - 1 >= 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i - 1, j]);
                    if (i - 1 < 0 && j - 1 >= 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[size - 1, j - 1]);
                    else if (i - 1 < 0 && j - 1 < 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[size - 1, size - 1]);
                    else if (i - 1 >= 0 && j - 1 < 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i - 1, size - 1]);
                    else if (i - 1 >= 0 && j - 1 >= 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i - 1, j - 1]);

                    if (i - 1 < 0 && j + 1 > size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[size - 1, 0]);
                    else if (i - 1 >= 0 && j + 1 > size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i - 1, 0]);
                    else if (i - 1 < 0 && j + 1 <= size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[size - 1, j + 1]);
                    else if (i - 1 >= 0 && j - 1 <= 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i - 1, j + 1]);

                    if (i + 1 <= size - 1 && j + 1 <= size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i + 1, j + 1]);
                    else if (i + 1 > size - 1 && j + 1 <= size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[0, j + 1]);
                    else if (i + 1 <= size - 1 && j + 1 > size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i + 1, 0]);
                    else if (i + 1 > size - 1 && j + 1 > size - 1)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[0, 0]);

                    if (i + 1 <= size - 1 && j - 1 >= 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i + 1, j - 1]);
                    else if (i + 1 > size - 1 && j - 1 >= 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[0, j - 1]);
                    else if (i + 1 <= size - 1 && j - 1 < 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[i + 1, size - 1]);
                    else if (i + 1 > size - 1 && j - 1 < 0)
                        planetMap[i, j].IncreaseIfBordererAlive(planetMap[0, size - 1]);

                    if (planetMap[i, j].CellStatus() == false && planetMap[i, j].ShowBorderer() == 3)
                        planetMapCopy[i, j].CellSeter = true;
                    else if ((planetMap[i, j].CellStatus() == true && planetMap[i, j].ShowBorderer() > 3) || (planetMap[i, j].CellStatus() == true && planetMap[i, j].ShowBorderer() < 2))
                        planetMapCopy[i, j].CellSeter = false;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    planetMap[i, j].CellSeter = planetMapCopy[i, j].CellStatus();
            }
        }

        public string IsAlive()
        {
            return cellsAlive.ToString();
        }

        public string IsDead()
        {
            return cellsDead.ToString();
        }

        public string IsGeneration()
        {
            return generation.ToString();
        }

        public int Widness()
        {
            return 10 * size;
        }
    }
}
