using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegaJuego
{
    internal class Personaje
    {
        private int coordX;
        private int coordY;
        private Level1 lienzo;
        private PictureBox caja=new PictureBox();
        private String direccion;

        //Constructor 
        public Personaje(Level1 vegaZelda, int x, int y)
        {
            coordX = x; 
            coordY = y;
            lienzo = vegaZelda;
            direccion = "Derecha";
            caja.Location=new System.Drawing.Point(coordX, coordY);
            caja.BackColor = System.Drawing.Color.Transparent; ;
            caja.Size = new System.Drawing.Size(110, 110);
            caja.BackgroundImageLayout=System.Windows.Forms.ImageLayout.None;
            caja.BackgroundImage = global::VegaJuego.Properties.Resources.derecha;

            vegaZelda.Controls.Add(caja); caja.Visible = true;
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int CoordY
        {
            get { return coordY; }
            set { coordY = value; }
        }

        public int CoordX
        {
            get { return coordX; }
            set { coordX = value; }
        }

        public Level1 Lienzo
        {
            get { return lienzo; } 
            set { lienzo = value; }
        }
        public PictureBox Caja
        {
            get { return caja; } 
            set { caja = value; }
        }

        //Método que se definirá en clases hijas 
        public void mover() { }
    }
}
