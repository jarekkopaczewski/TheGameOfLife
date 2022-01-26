namespace TheGameOfLife
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.NumberOfGeneration = new System.Windows.Forms.Label();
            this.NumberOfCellsAlive = new System.Windows.Forms.Label();
            this.NumberOfDeadCells = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // NumberOfGeneration
            // 
            this.NumberOfGeneration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfGeneration.AutoSize = true;
            this.NumberOfGeneration.BackColor = System.Drawing.Color.Black;
            this.NumberOfGeneration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumberOfGeneration.Location = new System.Drawing.Point(617, -1);
            this.NumberOfGeneration.Name = "NumberOfGeneration";
            this.NumberOfGeneration.Size = new System.Drawing.Size(16, 17);
            this.NumberOfGeneration.TabIndex = 0;
            this.NumberOfGeneration.Text = "0";
            // 
            // NumberOfCellsAlive
            // 
            this.NumberOfCellsAlive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumberOfCellsAlive.AutoSize = true;
            this.NumberOfCellsAlive.BackColor = System.Drawing.Color.Black;
            this.NumberOfCellsAlive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumberOfCellsAlive.Location = new System.Drawing.Point(617, 33);
            this.NumberOfCellsAlive.Name = "NumberOfCellsAlive";
            this.NumberOfCellsAlive.Size = new System.Drawing.Size(16, 17);
            this.NumberOfCellsAlive.TabIndex = 1;
            this.NumberOfCellsAlive.Text = "0";
            // 
            // NumberOfDeadCells
            // 
            this.NumberOfDeadCells.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfDeadCells.AutoSize = true;
            this.NumberOfDeadCells.BackColor = System.Drawing.Color.Black;
            this.NumberOfDeadCells.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumberOfDeadCells.Location = new System.Drawing.Point(617, 16);
            this.NumberOfDeadCells.Name = "NumberOfDeadCells";
            this.NumberOfDeadCells.Size = new System.Drawing.Size(16, 17);
            this.NumberOfDeadCells.TabIndex = 2;
            this.NumberOfDeadCells.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1082, 953);
            this.Controls.Add(this.NumberOfDeadCells);
            this.Controls.Add(this.NumberOfCellsAlive);
            this.Controls.Add(this.NumberOfGeneration);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "TheGameOfLife";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label NumberOfGeneration;
        private System.Windows.Forms.Label NumberOfCellsAlive;
        private System.Windows.Forms.Label NumberOfDeadCells;
    }
}

