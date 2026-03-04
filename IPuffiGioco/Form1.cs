using IPuffiGioco.Properties;

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
        Punto gargamella = new Punto(650, 185);

        int punteggio = 0;
        int punteggioGarg = 0;

        int velocita = 10;

        int turno = 0;
        bool turnoPuffo = true;

        Panel[] alberi = new Panel[10];
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            string percorso = Path.Combine(Application.StartupPath, "Img", "albero.png");       //percorso relativo
            Image imgAlbero = Image.FromFile(percorso);

            for (int i = 0; i < alberi.Length; i++)
            {
                Panel pnlAlbero = new Panel();
                pnlAlbero.Width = 60;
                pnlAlbero.Height = 90;

                pnlAlbero.BackgroundImage = imgAlbero;
                pnlAlbero.BackgroundImageLayout = ImageLayout.Stretch;
                pnlAlbero.BackColor = Color.Transparent;

                alberi[i] = pnlAlbero;
                pnlGioco.Controls.Add(pnlAlbero);

            }
            pnlCasetta.SendToBack();

            PosAberi();
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            casa.x = pnlCasetta.Left;
            casa.y = pnlCasetta.Top;
            puffo.x = pnlPuffo.Left;
            puffo.y = pnlPuffo.Top;
            gargamella.x = pnlGargamella.Left;
            gargamella.y = pnlGargamella.Top;

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
                case Keys.J:
                    gargamella.x -= velocita;
                    break;
                case Keys.L:
                    gargamella.x += velocita;
                    break;
                case Keys.I:
                    gargamella.y -= velocita;
                    break;
                case Keys.K:
                    gargamella.y += velocita;
                    break;
            }
            if (turnoPuffo)
            {
                lblTurno.Text = "Turno: Puffo";
                ControlloLimite(puffo, pnlPuffo);
                turno++;

            }
            else
            {
                lblTurno.Text = "Turno: Gargamella";
                ControlloLimite(gargamella, pnlGargamella);
                turno++;
            }
            if (turno >= 10)
            {
                turnoPuffo = !turnoPuffo;
                turno = 0;
            }

            //controllo puffo-casa
            if (pnlPuffo.Bounds.IntersectsWith(pnlCasetta.Bounds))
            {
                punteggio++;
                lblPunteggio.Text = $"Punteggio Puffo: {punteggio}";

                do
                {
                    casa.x = rnd.Next(0, pnlGioco.Width - pnlCasetta.Width);
                    casa.y = rnd.Next(0, pnlGioco.Height - pnlCasetta.Height);
                    pnlCasetta.Location = new Point(casa.x, casa.y);

                } while (pnlCasetta.Bounds.IntersectsWith(pnlPuffo.Bounds));

                PosAberi();

            }

            //controllo puffo-gargamella
            if (pnlGargamella.Bounds.IntersectsWith(pnlPuffo.Bounds))
            {
                punteggio--;
                punteggioGarg++;
                lblPunteggio.Text = $"Punteggio Puffo: {punteggio}";
                lblPuntGarg.Text = $"Punteggio Gargamella: {punteggioGarg}";

                puffo.x = rnd.Next(0, pnlGioco.Width - pnlPuffo.Width);
                puffo.y = rnd.Next(0, pnlGioco.Height - pnlPuffo.Height);

                do
                {
                    puffo.x = rnd.Next(0, pnlGioco.Width - pnlPuffo.Width);
                    puffo.y = rnd.Next(0, pnlGioco.Height - pnlPuffo.Height);
                    pnlPuffo.Location = new Point(puffo.x, puffo.y);
                } while (pnlPuffo.Bounds.IntersectsWith(pnlCasetta.Bounds) ||
                         pnlPuffo.Bounds.IntersectsWith(pnlGargamella.Bounds));

            }

            //controllo turni
            if (turnoPuffo)
            {
                if (PersoTurno(pnlPuffo))
                {
                    turnoPuffo = false;
                    turno = 0;
                    lblTurno.Text = "Turno: Gargamella";
                    return;
                }
            }
            else
            {
                if (PersoTurno(pnlGargamella))
                {
                    turnoPuffo = true;
                    turno = 0;
                    lblTurno.Text = "Turno: Puffo";
                    return;
                }
            }
        }

        void ControlloLimite(Punto pers, Panel persPan)         //limite campo da gioco
        {
            if (pers.x > pnlGioco.Width - persPan.Width)
                pers.x = pnlGioco.Width - persPan.Width;

            if (pers.y > pnlGioco.Height - persPan.Height)
                pers.y = pnlGioco.Height - persPan.Height;

            if (pers.x < 0)
                pers.x = 0;
            if (pers.y < 0)
                pers.y = 0;

            persPan.Location = new Point(pers.x, pers.y);
        }

        void PosAberi()             //alberi colpiti
        {
            for (int i = 0; i < alberi.Length; i++)
            {
                Panel pnlAlbero = alberi[i];
                bool posValida;

                do
                {
                    pnlAlbero.Location = new Point(
                        rnd.Next(0, pnlGioco.Width - pnlAlbero.Width),
                        rnd.Next(0, pnlGioco.Height - pnlAlbero.Height));

                    posValida = true;
                    if (pnlAlbero.Bounds.IntersectsWith(pnlCasetta.Bounds) ||
                        pnlAlbero.Bounds.IntersectsWith(pnlPuffo.Bounds) ||
                        pnlAlbero.Bounds.IntersectsWith(pnlGargamella.Bounds))
                    {
                        posValida = false;
                    }


                } while (!posValida);
            }
        }

        bool PersoTurno(Panel persPan)          //ha intersecato l'albero un personaggio
        {
            foreach (Panel albero in alberi)
            {
                if (persPan.Bounds.IntersectsWith(albero.Bounds))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
