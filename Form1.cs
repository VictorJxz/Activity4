using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();
            bool rest = false;
            if (rest == false)
            {
                button10.Enabled = false;
            }

        }

        bool x = true;
        bool o = false;
        string equis = "";
        string circulo = "";
        int counter = 0;        // new
        bool esEmpate = true;       //new
        bool gameOver = false;      // new


        public void Circulos()
        {
            //Horizontal
            if (uno.Text.Equals("O") && dos.Text.Equals("O") && tres.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
                //# Funcion de reiniciar la aplicacion al optener un resultado, ya realiza validaciones
                //y se puede encontrarse mas de los valor esperado.
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            if (cuatro.Text.Equals("O") && cinco.Text.Equals("O") && seis.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            if (siete.Text.Equals("O") && ocho.Text.Equals("O") && nueve.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }
            //vertical
            if (uno.Text.Equals("O") && cuatro.Text.Equals("O") && siete.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            if (dos.Text.Equals("O") && cinco.Text.Equals("O") && ocho.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            if (tres.Text.Equals("O") && seis.Text.Equals("O") && nueve.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            //diagonal
            if (uno.Text.Equals("O") && cinco.Text.Equals("O") && nueve.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }


            if (tres.Text.Equals("O") && cinco.Text.Equals("O") && siete.Text.Equals("O"))
            {
                MessageBox.Show("ha ganado  " + circulo);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

        }
        public void Equis()
        {
            //Horizontal
            if (uno.Text.Equals("X") && dos.Text.Equals("X") && tres.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            if (cuatro.Text.Equals("X") && cinco.Text.Equals("X") && seis.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            if (siete.Text.Equals("X") && ocho.Text.Equals("X") && nueve.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }
            //vertical
            if (uno.Text.Equals("X") && cuatro.Text.Equals("X") && siete.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis );
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            if (dos.Text.Equals("X") && cinco.Text.Equals("X") && ocho.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            if (tres.Text.Equals("X") && seis.Text.Equals("X") && nueve.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }

            // Error : Al validar no es de acuerdo a lo esperado, eso genera un comportamiento no esperado.
            // Se encontro el valor de [O] cuando se esperaba [X].
            //diagonal
            if (uno.Text.Equals("X") && cinco.Text.Equals("X") && nueve.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }


            if (tres.Text.Equals("X") && cinco.Text.Equals("X") && siete.Text.Equals("X"))
            {
                MessageBox.Show("ha ganado  " + equis);
                this.esEmpate = false;
                this.gameOver = true;
                Application.Restart();
            }


        }

        //Funcion agregada 
        public void JuegoEmpate()
        {
            if(this.gameOver == false && counter == 9 && esEmpate )
            {
                this.gameOver = true;
                MessageBox.Show("Juego empatado!" );
                Application.Restart();
            } 
        }
        //Funcion agregada
        public void automata()
        {
            bool finish = false;
            int counterx = 0;
            int checkOption = 0;
            bool banner = false;
            Random random = new Random();

            while ( finish == false )
            {
                if ( uno.Enabled == true)
                {
                    counterx++;
                    if ( banner && counterx == checkOption )
                    {
                        uno.Text = "O";
                        uno.Enabled = false;
                        finish = true;
                        break;
                    }
                }
                if ( dos.Enabled == true )
                {
                    counterx++;
                    if ( banner && counterx == checkOption)
                    {
                        dos.Text = "O";
                        dos.Enabled = false;
                        finish = true;
                        break;
                    }
                }
                if (tres.Enabled == true)
                {
                    counterx++;
                    if (banner && counterx == checkOption)
                    {
                        tres.Text = "O";
                        tres.Enabled = false;
                        finish = true;
                        break;
                    }
                }
                if ( cuatro.Enabled == true)
                {
                    counterx++;
                    if (banner && counterx == checkOption)
                    {
                        cuatro.Text = "O";
                        cuatro.Enabled = false;
                        finish = true;
                        break;
                    }
                }
                if (cinco.Enabled == true)
                {
                    counterx++;
                    if (banner && counterx == checkOption)
                    {
                        cinco.Text = "O";
                        cinco.Enabled = false;
                        finish = true;
                        break;
                    }
                }
                if ( seis.Enabled == true)
                {
                    counterx++;
                    if (banner && counterx == checkOption)
                    {
                        seis.Text = "O";
                        seis.Enabled = false;
                        finish = true;
                        break;
                    }
                }
                if ( siete.Enabled == true)
                {
                    counterx++;
                    if (banner && counterx == checkOption)
                    {
                        siete.Text = "O";
                        siete.Enabled = false;
                        finish = true;
                        break;
                    }
                }
                if ( ocho.Enabled == true )
                {
                    counterx++;
                    if (banner && counterx == checkOption)
                    {
                        ocho.Text = "O";
                        ocho.Enabled = false;
                        finish = true;
                        break;
                    }
                }
                if (nueve.Enabled == true)
                {
                    counterx++;
                    if (banner &&  counterx == checkOption)
                    {
                        nueve.Text = "O";
                        nueve.Enabled = false;
                        finish = true;
                        break;
                    }
                }
                if( !banner)
                {
                    checkOption = random.Next( 1, counterx+1);
                    banner = true;
                }
                if( counterx == 0)
                {
                    finish = true;
                    break;
                }
                counterx = 0;
            }

        }

        public void AsignarValor(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            
            /* [  x == true ] Código que nos permite iniciar con “x” en el primer movimiento. 
            ya que hace la validacion y la variable X tiene el valor de [true]. lo cual el primer
            valor a marcar resia "x". */
            if (x == true)
            {
                btn.Text = "X";
                counter++;
                x = false;
                o = true;
                btn.Enabled = false;
                radioButton1.Checked = true;

                if (this.gameOver == false && x == false && circulo == "machine" && counter < 9)
                {
                    counter++;
                    automata();
                    o = false;
                    x = true;
                    radioButton2.Checked = true;
                }
            }
            else if (!(circulo == "machine"))
            {
                btn.Text = "O";
                counter++;
                o = false;
                x = true;
                btn.Enabled = false;
                radioButton2.Checked = true;
            }

            this.Circulos();
            this.Equis();
            this.JuegoEmpate();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();
            textBox2.Visible = true;
            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equis = textBox1.Text;
            radioButton1.Text = equis;
            circulo = textBox2.Text;
            radioButton2.Text = circulo;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            uno.Enabled = true;
            dos.Enabled = true;
            tres.Enabled = true;
            cuatro.Enabled = true;
            cinco.Enabled = true;
            seis.Enabled = true;
            siete.Enabled = true;
            ocho.Enabled = true;
            nueve.Enabled = true;
            button10.Enabled = true;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}