using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameOfLife
{
    public partial class MainForm : Form
    {
        Planet planet = new Planet(60);
        
        public MainForm()
        {
            InitializeComponent();
            NumberOfGeneration.Left = planet.Widness() + 1;
            NumberOfCellsAlive.Left = planet.Widness() + 1;
            NumberOfDeadCells.Left = planet.Widness() + 1;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            planet.Cycle();
            planet.Generation();
            NumberOfGeneration.Text = "Numer generacji : " + planet.IsGeneration();
            NumberOfCellsAlive.Text = "Ilość żywych komórek : " + planet.IsAlive();
            NumberOfDeadCells.Text = "Ilość martwych komórek : " + planet.IsDead();
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            planet.Draw(e);
        }
    }
}
