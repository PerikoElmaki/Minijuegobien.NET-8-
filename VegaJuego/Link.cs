using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegaJuego
{
    internal class Link : Personaje
    {
        private int salud;
        private int escudo;
        private int arma;

        //Constructor 
        public Link(Level1 vegaZelda, int x, int y, int s, int e, int a): base(vegaZelda, x, y)
        {
            salud = s;
            escudo=e;
            arma = a;
        }

        public int Arma
        {
            get { return arma; }
            set { arma = value; }
        }
        public int Escudo
        {
            get { return escudo; } 
            set { escudo = value; }
        }

        public int Salud
        {
            get { return salud; }
            set { salud = value; }  
        }

        
            public void mover(KeyPressEventArgs e) { 
                if (e.KeyChar == 'w' && (Caja.Location.Y > 0))
                 {
                      this.Direccion = "ARRIBA";
                      this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Arriba;
                     this.Caja.Location = new Point(this.Caja.Location.X, this.Caja.Location.Y - 10);
                }
            if (e.KeyChar == 's' && (Caja.Location.Y < Lienzo.Size.Height - 160))
            {
                this.Direccion = "ABAJO";
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Abajo;
                this.Caja.Location = new Point(this.Caja.Location.X, this.Caja.Location.Y + 10);
            }
            if (e.KeyChar == 'd' && (Caja.Location.X < Lienzo.Size.Width - 120))
            {
                this.Direccion = "DERECHA";
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.derecha;
                this.Caja.Location = new Point(this.Caja.Location.X + 10, this.Caja.Location.Y);
            }
            if (e.KeyChar == 'a' && (Caja.Location.X > 0))
            {
                this.Direccion = "IZQUIERDA";
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.izquierda;
                this.Caja.Location = new Point(this.Caja.Location.X - 10, this.Caja.Location.Y);
            }
        }
    }
}
