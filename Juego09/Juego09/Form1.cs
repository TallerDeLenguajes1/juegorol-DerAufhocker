using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego09
{
    public partial class Form1 : Form
    {
        double player1Health = 100;//contiene la vida del jugador 1
        double player2Health = 100;//contiene la vida del jugador 2
        bool gameOver = false;//sirve para verificar si uno de los jugadores perdio

        public Form1()
        {
            InitializeComponent();
        }

        private void eventos(object sender, EventArgs e)
        {
            if(player1Health > 1)//compruebo si alguno de los jugadores sigue con vida
            {
                progressBar1.Value = Convert.ToInt32(player1Health);//modifico los valores de la vida de cada jugador
            }
            else
            {
                gameOver = true;//en caso de que su vida sea menor a 1 ierde el juego
            }

            if (player2Health > 1)//compruebo si alguno de los jugadores sigue con vida
            {
                progressBar2.Value = Convert.ToInt32(player2Health);//modifico los valores de la vida de cada jugador
            }
            else
            {
                gameOver = true;//en caso de que su vida sea menor a 1 ierde el juego
            }


        }
    }
}
