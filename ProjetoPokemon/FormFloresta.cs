using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPokemon
{
    public partial class FormFloresta : Form
    {

        private List<Pokemon> pokemons = new List<Pokemon>();
        private Treinador treinador;
        private FormPrincipal formPrincipal;
        private Pokemon poke;

        public FormFloresta(List<Pokemon> pokemons, Treinador treinador, FormPrincipal form)
        {
            this.pokemons = pokemons;
            this.treinador = treinador;
            this.formPrincipal = form;
            InitializeComponent();
            iniciaListView();
        }

        private void iniciaListView()
        {
            pictureBox1.Image = null;
            listBoxPokemon.Items.Clear();
            foreach (Pokemon poke in pokemons)
            {
                if (poke.Treinador == 0)
                {
                    listBoxPokemon.Items.Add(poke.Id.ToString() + "| " + poke.Nome);
                }
            }
        }

        public void Contrutor(Pokemon pokemonCapturado)
        {
            pokemons.First(p => p.Id == pokemonCapturado.Id).Treinador = pokemonCapturado.Treinador;
            iniciaListView();
        }


        private void ajustaImagem()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            if (pictureBox1.Width > 200)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Width = 200;
            }

            int locationX = 439 - (pictureBox1.Width / 2);
            int locationY = 430 - pictureBox1.Height;

            pictureBox1.Location = new Point(locationX, locationY);
        }

        private void listBoxPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = listBoxPokemon.SelectedItem.ToString();
            item = item.Split('|').First();
            poke = pokemons.First(p => p.Id == Convert.ToInt32(item));

            pictureBox1.Image = new Bitmap("../../Pokemons/" + poke.Foto);
            ajustaImagem();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            FormCapturar fc = new FormCapturar(poke, treinador, this);
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void FormFloresta_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Construtor(pokemons);
        }
    }
}
