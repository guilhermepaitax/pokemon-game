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
    public partial class FormCadastroPokemon : Form
    {
        //Variáveis
        private List<Pokemon> pokemons = new List<Pokemon>();
        private string aNome;
        private FormPrincipal formPrincipal;

        //Construtor
        public FormCadastroPokemon(List<Pokemon> pokemons, FormPrincipal form)
        {
            InitializeComponent();

            formPrincipal = form;
            this.pokemons = pokemons;
            cbxTipo1.SelectedIndex = 0; cbxTipo2.SelectedIndex = 0; cbxTipo3.SelectedIndex = 0;
        }

        //Adiciona Foto ao PictureBox
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

        //Cadastra o pokemon no arquivo de dados
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            try
            {
                int id;
                string tipo2 = string.Empty, tipo3 = string.Empty;

                if (pokemons.Count > 0)
                    id = pokemons.Last().Id + 1;
                else
                    id = 1;

                string foto = id.ToString() + aNome.Split('\\').Last();
                Pokemon poke = new Pokemon(txtNome.Text, id, (double)numericUpDownPeso.Value, (double)numericUpDownAltura.Value,txtEvolucao.Text, foto);
                
                poke.Tipo = cbxTipo1.SelectedItem.ToString();

                if (cbxTipo2.SelectedIndex != 0)
                    poke.Tipo += "," + cbxTipo2.SelectedItem.ToString();
                if(cbxTipo3.SelectedIndex != 0)
                    poke.Tipo += "," + cbxTipo3.SelectedItem.ToString();

                pokemons.Add(poke);

                FileInfo imagem = new FileInfo(aNome);
                imagem.CopyTo("../../Pokemons/" + foto, true);
                StreamWriter writer = File.AppendText("../../Save/dadosPokemons.txt");
                writer.Write(poke.Id + ";" + poke.Nome + ";" + poke.Peso + ";" + poke.Altura + ";" + poke.Evolucao + ";" + poke.Foto + ";"
                    + poke.Vida + ";" + poke.Treinador + ";" + poke.Efeito + ";" + poke.Defesa.ToString() + ";" + poke.Forca.ToString() + ";" + poke.Tipo + ";" 
                    + poke.ForcaMax.ToString() + ";" + poke.DefesaMax.ToString() + Environment.NewLine);
                writer.Close();
                MessageBox.Show("Cadastro realizado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                formPrincipal.Construtor(pokemons);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
