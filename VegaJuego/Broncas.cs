using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegaJuego
{
    internal class Broncas : Personaje
    {
        public Broncas(Level1 vegaZelda, int x, int y) : base(vegaZelda, x, y)
        { 
        
        Caja.BackgroundImage=global::VegaJuego.Properties.Resources.Broncas_abajo;
 
        }

        public new void mover() 
        {
            if(Direccion == "Derecha")
            {
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Broncas_Derecha;
                this.Caja.Location = new Point(Caja.Location.X + 20, this.Caja.Location.Y);
                if(Caja.Location.X>Lienzo.Size.Width-120)
                {
                    Direccion = "Izquierda";
                }

            }
            if(Direccion=="Izquierda")
            {
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Broncas_Izquierda;
                this.Caja.Location = new Point(Caja.Location.X - 20, this.Caja.Location.Y);
                if(Caja.Location.X<0)
                {
                    Direccion = "Derecha";
                }
            }
        
        
        
        }
    }
}
