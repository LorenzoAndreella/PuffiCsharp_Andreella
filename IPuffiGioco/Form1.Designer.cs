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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlGioco = new Panel();
            lblPuntGarg = new Label();
            lblTurno = new Label();
            pnlGargamella = new Panel();
            lblPunteggio = new Label();
            pnlCasetta = new Panel();
            pnlPuffo = new Panel();
            pnlGioco.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGioco
            // 
            pnlGioco.BackgroundImage = (Image)resources.GetObject("pnlGioco.BackgroundImage");
            pnlGioco.Controls.Add(lblPuntGarg);
            pnlGioco.Controls.Add(lblTurno);
            pnlGioco.Controls.Add(pnlGargamella);
            pnlGioco.Controls.Add(lblPunteggio);
            pnlGioco.Controls.Add(pnlCasetta);
            pnlGioco.Controls.Add(pnlPuffo);
            pnlGioco.Dock = DockStyle.Fill;
            pnlGioco.Location = new Point(0, 0);
            pnlGioco.Name = "pnlGioco";
            pnlGioco.Size = new Size(800, 450);
            pnlGioco.TabIndex = 0;
            // 
            // lblPuntGarg
            // 
            lblPuntGarg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPuntGarg.AutoSize = true;
            lblPuntGarg.Location = new Point(11, 413);
            lblPuntGarg.Name = "lblPuntGarg";
            lblPuntGarg.Size = new Size(130, 15);
            lblPuntGarg.TabIndex = 5;
            lblPuntGarg.Text = "Puteggio Gargamella: 0";
            // 
            // lblTurno
            // 
            lblTurno.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(651, 21);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(74, 15);
            lblTurno.TabIndex = 4;
            lblTurno.Text = "Turno: Puffo";
            // 
            // pnlGargamella
            // 
            pnlGargamella.BackColor = Color.Transparent;
            pnlGargamella.BackgroundImage = (Image)resources.GetObject("pnlGargamella.BackgroundImage");
            pnlGargamella.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGargamella.Location = new Point(650, 185);
            pnlGargamella.Name = "pnlGargamella";
            pnlGargamella.Size = new Size(50, 96);
            pnlGargamella.TabIndex = 3;
            // 
            // lblPunteggio
            // 
            lblPunteggio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPunteggio.AutoSize = true;
            lblPunteggio.Location = new Point(651, 413);
            lblPunteggio.Name = "lblPunteggio";
            lblPunteggio.Size = new Size(106, 15);
            lblPunteggio.TabIndex = 2;
            lblPunteggio.Text = "Punteggio Puffo: 0";
            // 
            // pnlCasetta
            // 
            pnlCasetta.BackColor = Color.Transparent;
            pnlCasetta.BackgroundImage = (Image)resources.GetObject("pnlCasetta.BackgroundImage");
            pnlCasetta.BackgroundImageLayout = ImageLayout.Stretch;
            pnlCasetta.Location = new Point(0, 0);
            pnlCasetta.Name = "pnlCasetta";
            pnlCasetta.Size = new Size(166, 96);
            pnlCasetta.TabIndex = 1;
            // 
            // pnlPuffo
            // 
            pnlPuffo.BackColor = Color.Transparent;
            pnlPuffo.BackgroundImage = (Image)resources.GetObject("pnlPuffo.BackgroundImage");
            pnlPuffo.BackgroundImageLayout = ImageLayout.Stretch;
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
        private Panel pnlGargamella;
        private Label lblTurno;
        private Label lblPuntGarg;
    }
}
