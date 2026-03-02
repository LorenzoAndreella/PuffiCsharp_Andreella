namespace IPuffiGioco
{
    public partial class Form1 : Form
    {
        
        public struct Punto
        {
            public int x;
            public int y;
            public Punto(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        Punto puffo = new Punto(400, 185);
        Punto casa = new Punto(10, 10);
        int punteggio = 0;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int velocita = 10;
            int x1 = pnlCasetta.Left;
            int x2 = pnlCasetta.Top;
            casa.x = x1;
            casa.y = x2;
            int x = pnlPuffo.Left;
            int y = pnlPuffo.Top;
            puffo.x = x;
            puffo.y = y;
            switch (e.KeyCode)
            {
                case Keys.A:
                    puffo.x -= velocita;
                    break;
                case Keys.D:
                    puffo.x += velocita;
                    break;
                case Keys.W:
                    puffo.y -= velocita;
                    break;
                case Keys.S:
                    puffo.y += velocita;
                    break;
            }

            if (puffo.x > pnlGioco.Width - pnlPuffo.Width)          
                 puffo.x = pnlGioco.Width - pnlPuffo.Width;
            if (puffo.y > pnlGioco.Height - pnlPuffo.Height)
                puffo.y = pnlGioco.Height - pnlPuffo.Height;
            if (puffo.x < 0)
                puffo.x = 0;
            if (puffo.y < 0)
                puffo.y = 0;

            pnlPuffo.Location = new Point(puffo.x, puffo.y);
            Random rnd = new Random();
            if (casa.x < puffo.x + pnlPuffo.Width && casa.x + pnlCasetta.Width > puffo.x
                && casa.y < puffo.y + pnlPuffo.Height && casa.y + pnlCasetta.Height > puffo.y)
            {
                punteggio++;
                lblPunteggio.Text = $"Punteggio: {punteggio}";
                casa.x = rnd.Next(1, pnlGioco.Width - pnlCasetta.Width);
                casa.y = rnd.Next(1 + pnlGioco.Height -pnlCasetta.Height);

                do
                {
                    casa.x = rnd.Next(0, pnlGioco.Width - pnlCasetta.Width);
                    casa.y = rnd.Next(0, pnlGioco.Height - pnlCasetta.Height);

                } while (
                casa.x < puffo.x + pnlPuffo.Width &&
                casa.x + pnlCasetta.Width > puffo.x &&
                casa.y < puffo.y + pnlPuffo.Height &&
                casa.y + pnlCasetta.Height > puffo.y
                );

                pnlCasetta.Location = new Point(casa.x, casa.y);
            }
        }
    }
}
