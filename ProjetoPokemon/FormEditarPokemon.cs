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
    public partial class FormEditarPokemon : Form
    {
        private Pokemon pokemon;
        private FormPrincipal formPrincipal;
        private string aNome;

        public FormEditarPokemon(Pokemon poke, FormPrincipal form)
        {
            InitializeComponent();
            pokemon = poke;
            formPrincipal = form;
            cbxTipo1.SelectedIndex = 0; cbxTipo2.SelectedIndex = 0; cbxTipo3.SelectedIndex = 0;
            IniciaPokemon();
        }

        private void IniciaPokemon()
        {
            
            txtNome.Text = pokemon.Nome;
            txtEvolucao.Text = pokemon.Evolucao;
            numericUpDownAltura.Value = Convert.ToDecimal(pokemon.Altura);
            numericUpDownPeso.Value = Convert.ToDecimal(pokemon.Peso);
            pictureBox1.Image = new Bitmap("../../Pokemons/" + pokemon.Foto);
            string[] tipo = pokemon.Tipo.Split(',');
            cbxTipo1.SelectedItem = tipo[0];
            if (tipo.Length == 2) cbxTipo2.SelectedItem = tipo[1];
            else if (tipo.Length == 3)
            {
                cbxTipo2.SelectedItem = tipo[1];
                cbxTipo3.SelectedItem = tipo[2];
            }

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.gif, *.png) | *.jpg; *.jpeg; *.jpe; *.gif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName); 
                aNome = openFileDialog1.FileName;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string foto = pokemon.Foto;
            if (aNome != null)
            {
                foto = pokemon.Id.ToString() + aNome.Split('\\').Last();
                FileInfo imagem = new FileInfo(aNome);
                imagem.CopyTo("../../Pokemons/" + foto, true);
            }

            Pokemon poke = new Pokemon(txtNome.Text, pokemon.Id, (double)numericUpDownPeso.Value, (double)numericUpDownAltura.Value, txtEvolucao.Text, foto);

            poke.Tipo = cbxTipo1.SelectedItem.ToString();

            ////////////////////////Melhorar////////////////////////
            if (cbxTipo2.SelectedIndex != 0)
                poke.Tipo += "," + cbxTipo2.SelectedItem.ToString();
            if (cbxTipo3.SelectedIndex != 0)
                poke.Tipo += "," + cbxTipo3.SelectedItem.ToString();

            EditarArquivo.AtualizaArquivoPokemon(poke);

            formPrincipal.Construtor(poke);

            MessageBox.Show("Pokemon editado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
