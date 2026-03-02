namespace IPuffiGioco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlGioco = new Panel();
            lblPunteggio = new Label();
            pnlCasetta = new Panel();
            pnlPuffo = new Panel();
            pnlGioco.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGioco
            // 
            pnlGioco.Controls.Add(lblPunteggio);
            pnlGioco.Controls.Add(pnlCasetta);
            pnlGioco.Controls.Add(pnlPuffo);
            pnlGioco.Location = new Point(1, 1);
            pnlGioco.Name = "pnlGioco";
            pnlGioco.Size = new Size(799, 452);
            pnlGioco.TabIndex = 0;
            // 
            // lblPunteggio
            // 
            lblPunteggio.AutoSize = true;
            lblPunteggio.Location = new Point(699, 11);
            lblPunteggio.Name = "lblPunteggio";
            lblPunteggio.Size = new Size(74, 15);
            lblPunteggio.TabIndex = 2;
            lblPunteggio.Text = "Punteggio: 0";
            // 
            // pnlCasetta
            // 
            pnlCasetta.BackColor = Color.Red;
            pnlCasetta.Location = new Point(0, 0);
            pnlCasetta.Name = "pnlCasetta";
            pnlCasetta.Size = new Size(166, 96);
            pnlCasetta.TabIndex = 1;
            // 
            // pnlPuffo
            // 
            pnlPuffo.BackColor = SystemColors.MenuHighlight;
            pnlPuffo.Location = new Point(400, 185);
            pnlPuffo.Name = "pnlPuffo";
            pnlPuffo.Size = new Size(51, 96);
            pnlPuffo.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlGioco);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            pnlGioco.ResumeLayout(false);
            pnlGioco.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGioco;
        private Panel pnlPuffo;
        private Panel pnlCasetta;
        private Label lblPunteggio;
    }
}
