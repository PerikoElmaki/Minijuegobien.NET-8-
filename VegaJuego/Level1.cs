

using System.Diagnostics;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        Broncas Enemigo1;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
        }

        private void IniciarPersonajes()
        {
            //Atributos Lienzo,coordX,Y,salud,escudo y arma
            Player = new Link(this, 0, 0, 30, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
            Debug.WriteLine("[X" + Player.Caja.Location.X + ",Y" + Player.Caja.Location.Y + "]");
        }

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Enemigo1.mover();
        }
    }
}
