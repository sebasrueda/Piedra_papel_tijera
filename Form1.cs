namespace Piedra_papel_tijera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int jugador;
        private void btnPiedra_Click(object sender, EventArgs e)
        {
            pbxTu.BackgroundImage = Image.FromFile(@"C:\Users\Estudios\Desktop\Piedra_papel_tijera\img\piedra.png");
            jugador = 1;
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            pbxTu.BackgroundImage = Image.FromFile(@"C:\Users\Estudios\Desktop\Piedra_papel_tijera\img\papel.png");
            jugador = 2;
        }

        private void btnTijeras_Click(object sender, EventArgs e)
        {
            pbxTu.BackgroundImage = Image.FromFile(@"C:\Users\Estudios\Desktop\Piedra_papel_tijera\img\tijeras.png");
            jugador = 3;
        }

        int computador;
        Random con = new Random();

        private void btnJugar_Click(object sender, EventArgs e)
        {
            computador = con.Next(1, 4);

            if (computador == 1)
            {
                pbxComputador.BackgroundImage = Image.FromFile(@"C:\Users\Estudios\Desktop\Piedra_papel_tijera\img\piedra.png");
            }
            else if (computador == 2)
            {
                pbxComputador.BackgroundImage = Image.FromFile(@"C:\Users\Estudios\Desktop\Piedra_papel_tijera\img\papel.png");
            }
            else if (computador == 3)
            {
                pbxComputador.BackgroundImage = Image.FromFile(@"C:\Users\Estudios\Desktop\Piedra_papel_tijera\img\tijeras.png");
            }

            // El usuario elige piedra (1)
            if (jugador == 1 && computador == 1)
            {
                MessageBox.Show("El compuador y tú empataron");
            }
            else if (jugador == 1 && computador == 2)
            {
                MessageBox.Show("Perdiste");
            }
            else if (jugador == 1 && computador == 3)
            {
                MessageBox.Show("¡Ganaste!");
            }

            // El usuario elige papel (2)
            else if (jugador == 2 && computador == 1)
            {
                MessageBox.Show("¡Ganaste!");
            }
            else if (jugador == 2 && computador == 2)
            {
                MessageBox.Show("El compuador y tú empataron");
            }
            else if (jugador == 2 && computador == 3)
            {
                MessageBox.Show("Perdiste");
            }

            // El usuario elige tijeras (3)
            else if (jugador == 3 && computador == 1)
            {
                MessageBox.Show("Perdiste");
            }
            else if (jugador == 3 && computador == 2)
            {
                MessageBox.Show("¡Ganaste!");
            }
            else if (jugador == 3 && computador == 3)
            {
                MessageBox.Show("El compuador y tú empataron");
            }
        }
    }
}