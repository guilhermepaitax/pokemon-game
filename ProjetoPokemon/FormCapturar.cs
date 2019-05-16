using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPokemon
{
    public partial class FormCapturar : Form
    {
        private Pokemon pokemon;
        private Treinador treinador;
        private FormFloresta formFloresta;
        private bool key;
        public FormCapturar(Pokemon pokemon, Treinador treinador, FormFloresta form)
        {
            this.pokemon = pokemon;
            this.treinador = treinador;
            this.formFloresta = form;
            InitializeComponent();
            IniciaPokemon();
        }

        //Velocidade do pokemon
        private int velPokemon = 0;

        //Inicia imagem e velocidade do pokemon 
        private void IniciaPokemon()
        {
            pictureBoxPoke.Image = new Bitmap("../../Pokemons/" + pokemon.Foto);
            velPokemon = (pokemon.Forca / 2);
            ajustaImagem();
        }

        //Variáveis para controle do movimento
        private bool caminho = false;
        private bool caminhoPoke = false;

        //Ajusta o posicionamento da imagem do pokemon
        private void ajustaImagem()
        {
            pictureBoxPoke.SizeMode = PictureBoxSizeMode.AutoSize;

            if (pictureBoxPoke.Width > 200)
            {
                pictureBoxPoke.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxPoke.Width = 200;
            }
            
            int locationX = 401 - (pictureBoxPoke.Width / 2);
            int locationY = 190 - pictureBoxPoke.Height;

            pictureBoxPoke.Location = new Point(locationX, locationY);
        }


        //Movimento pokebola na vertical
        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Refresh();

            if (caminho)
            {
                pictureBoxBall.Left = (pictureBoxBall.Left + 15);
                if (pictureBoxBall.Left > 700)
                {
                    caminho = false;
                }
            }
            else
            {
                pictureBoxBall.Left = (pictureBoxBall.Left - 15);
                if (pictureBoxBall.Left < 10)
                {
                    caminho = true;
                }
            }

            if (key)
                timerX.Enabled = false;

        }

        //Tecla Enter pressionada
        private void FormCapturar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                key = true;
            }
        }

        private void timerY_Tick(object sender, EventArgs e)
        {
            
            this.Refresh();

            //Movimento e verificação da pokebola
            if (key)
            {
                pictureBoxBall.Top = (pictureBoxBall.Top - 5);

                if (pictureBoxBall.Top <= 117)
                {
                    timerY.Enabled = false;
                    pictureBoxPoke.Image = null;
                    //Pegou o Pokemon
                    if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxPoke.Bounds))
                    {
                        pictureBoxPoke.Image = new Bitmap("../../Pokemons/Fire.gif");
                        MessageBox.Show("Gotcha!, Você pegou o pokemon!");
                        pokemon.Treinador = treinador.Id;
                        EditarArquivo.AtualizaArquivoPokemon(pokemon);
                        formFloresta.Contrutor(pokemon);

                    }
                    //Errou
                    else
                    {
                        pictureBoxPoke.Image = new Bitmap("../../Pokemons/Folhas.gif");
                        MessageBox.Show("Você errou e o Pokemon escapou!");
                    }


                }
            }
            //Movimento do Pokemon
            else
            {
                if (caminhoPoke)
                {
                    pictureBoxPoke.Left = (pictureBoxPoke.Left + velPokemon);
                    if (pictureBoxPoke.Left > 500)
                    {
                        caminhoPoke = false;
                    }
                }
                else
                {
                    pictureBoxPoke.Left = (pictureBoxPoke.Left - velPokemon);
                    if (pictureBoxPoke.Left < 200)
                    {
                        caminhoPoke = true;
                    }
                }
            }

        }

    }
}
