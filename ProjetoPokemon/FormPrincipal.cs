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
    public partial class FormPrincipal : Form
    {
        //Variáveis
        private Treinador treinador;
        private List<Pokemon> pokemons = new List<Pokemon>();
        private int pokemonSelecionado = -1;

        public FormPrincipal(Treinador treinador)
        {
            InitializeComponent();
            //Inicia Treinador ativo
            this.treinador = treinador;
            LerDados();
            //Colocando tooltips nos botões
            toolTip1.SetToolTip(btnAddPokemon, "Adicionar Novo Pokemon");
            toolTip1.SetToolTip(btnTreinar, "Treinar Pokemon");
            toolTip1.SetToolTip(btnFloresta, "Procurar Pokemons");
            toolTip1.SetToolTip(btnAbandorar, "Abandonar Pokemon");
            toolTip1.SetToolTip(btnEditar, "Editar Pokemon");
            toolTip1.SetToolTip(btnExcluir, "Excluir Pokemon");
            toolTip1.SetToolTip(btnPerfil, "Editar Perfil");
            
            //Seleção dos pokemons
            dataGridViewPoke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPoke.MultiSelect = false;
            cbxSelecaoPoke.SelectedIndex = 0;
        }

        //Adiciona na lista os dados dos Pokemons do arquivo de dados
        private void LerDados()
        {
            lblTreinador.Text = treinador.Nome;
            
            StreamReader reader = new StreamReader("../../Save/dadosPokemons.txt");
            string linha = reader.ReadLine();

            while (linha != null)
            {
                string[] dados;
                dados = linha.Split(';');
                Pokemon p1 = new Pokemon();
                //////
                p1.Id = Convert.ToInt32(dados[0]);
                p1.Nome = dados[1];
                p1.Peso = Convert.ToDouble(dados[2]);
                p1.Altura = Convert.ToDouble(dados[3]);
                p1.Evolucao = dados[4];
                p1.Foto = dados[5];
                p1.Vida = Convert.ToInt32(dados[6]);
                p1.Treinador = Convert.ToInt32(dados[7]);
                p1.Efeito = Convert.ToInt32(dados[8]);
                p1.Defesa = Convert.ToInt32(dados[9]);
                p1.Forca = Convert.ToInt32(dados[10]);
                p1.Tipo = dados[11];
                p1.ForcaMax = Convert.ToInt32(dados[12]);
                p1.DefesaMax = Convert.ToInt32(dados[13]);

                pokemons.Add(p1);
                linha = reader.ReadLine();
            }
            reader.Close();
            IniciaPokemons();
        }

        //Inicia o DataGridView com a lista de Pokemons
        private void IniciaPokemons()
        {
            dataGridViewPoke.Rows.Clear();
            picBoxFoto.Image = null;
            picBoxTipo1.Image = null;
            picBoxTipo2.Image = null;
            picBoxTipo3.Image = null;
            lblAltura.Text = "Altura:";
            lblDefesa.Text = "";
            lblForca.Text = "";
            lblNome.Text = "";
            lblPeso.Text = "Peso:";
            lblVida.Text = "";
            progressBarDefesa.Value = 0;
            progressBarForca.Value = 0;
            progressBarVida.Value = 0;
            pokemonSelecionado = -1;
            btnTreinar.Visible = false;
            btnAbandorar.Visible = false;
            btnExcluir.Visible = false;
            btnEditar.Visible = false;
            int i = 0;
            if (cbxSelecaoPoke.SelectedIndex == 0)
            {
                btnTreinar.Visible = true;
                btnAbandorar.Visible = true;
                foreach (Pokemon poke in pokemons)
                {
                    if (poke.Treinador == treinador.Id)
                    {
                        dataGridViewPoke.Rows.Add();
                        dataGridViewPoke.Rows[i].HeaderCell.Value = poke.Id.ToString();
                        dataGridViewPoke.Rows[i].Cells[0].Value = poke.Nome;
                        dataGridViewPoke.Rows[i].Cells[1].Value = poke.Forca.ToString();
                        dataGridViewPoke.Rows[i].Cells[2].Value = poke.Altura;
                        dataGridViewPoke.Rows[i].Cells[3].Value = poke.Peso;
                        i++;
                    }
                }
            }
            else
            {
                btnEditar.Visible = true;
                btnExcluir.Visible = true;
                foreach (Pokemon poke in pokemons)
                {

                    dataGridViewPoke.Rows.Add();
                    dataGridViewPoke.Rows[i].HeaderCell.Value = poke.Id.ToString();
                    dataGridViewPoke.Rows[i].Cells[0].Value = poke.Nome;
                    dataGridViewPoke.Rows[i].Cells[1].Value = poke.Forca.ToString();
                    dataGridViewPoke.Rows[i].Cells[2].Value = poke.Altura;
                    dataGridViewPoke.Rows[i].Cells[3].Value = poke.Peso;
                    i++;

                }
            }

        }

        //Faz os ajuste de pocição e redimensionamento das imagens e textos
        private void AjustaItens()
        {
            picBoxFoto.SizeMode = PictureBoxSizeMode.AutoSize;
            int labelLocationX = 825 - lblNome.Width / 2;
            lblNome.Location = new Point(labelLocationX, 344);

            if (picBoxFoto.Width > 200)
            {
                picBoxFoto.Width = 200;
                picBoxFoto.Height = 200;
                picBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }

            int locationX = 840 - (picBoxFoto.Width / 2);
            int locationY = 286 - picBoxFoto.Height;
            if (locationY < 0)
                locationY = locationY * -1;
            picBoxFoto.Location = new Point(locationX, locationY);

        }


        //Exibe o Pokemon selecionado
        private void dataGridViewPoke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostraPokemon(e.RowIndex);
        }

        public void Construtor(List<Pokemon> pokemons)
        {
            this.pokemons = pokemons;
            IniciaPokemons();
        }

        public void Construtor(Treinador treinador)
        {
            this.treinador = treinador;
            lblTreinador.Text = treinador.Nome;
        }

        public void Construtor(Pokemon novoPokemon)
        {
            int index = pokemons.IndexOf(pokemons.First(p => p.Id == novoPokemon.Id));
            pokemons[index] = novoPokemon;   
            IniciaPokemons();
        }

        //Chama o Form para o cadastro de um novo POkemon
        private void btnAddPokemon_Click(object sender, EventArgs e)
        {
            
            FormCadastroPokemon fcp = new FormCadastroPokemon(pokemons, this);
            this.Hide();
            fcp.ShowDialog();
            this.Show();

        }

        //Muda exibição dos pokemons
        private void cbxSelecaoPoke_SelectedIndexChanged(object sender, EventArgs e)
        {
            IniciaPokemons();
        }

        //Chama Form de pegar pokemons
        private void button3_Click(object sender, EventArgs e)
        {
            FormFloresta ff = new FormFloresta(pokemons, treinador, this);
            this.Hide();
            ff.ShowDialog();
            this.Show();
        }

        //Busca pelo nome dos pokemons
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;

            try
            {
                foreach (DataGridViewRow row in dataGridViewPoke.Rows)
                {
                    if (row.Cells[0].Value.ToString().ToUpper().Contains(searchValue.ToUpper()))
                    {
                        row.Selected = true;
                        MostraPokemon(row.Index);
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Mostra detalhadamente o pokemon selecionado
        private void MostraPokemon(int index)
        {
            if (index == pokemonSelecionado) return;
            
            try
            {
                var i = dataGridViewPoke.Rows[index].HeaderCell.Value;
                picBoxTipo1.Image = null; picBoxTipo2.Image = null; picBoxTipo3.Image = null;
                Pokemon poke = pokemons.First(p => p.Id == Convert.ToInt32(i));

                progressBarForca.Maximum = Convert.ToInt32(poke.ForcaMax);
                progressBarDefesa.Maximum = Convert.ToInt32(poke.DefesaMax);

                picBoxFoto.Image = new Bitmap("../../Pokemons/" + poke.Foto);
                lblNome.Text = poke.Nome;
                progressBarForca.Value = poke.Forca;
                lblForca.Text = poke.Forca.ToString();
                progressBarDefesa.Value = poke.Defesa;
                lblDefesa.Text = poke.Defesa.ToString();
                progressBarVida.Value = poke.Vida;
                lblVida.Text = poke.Vida.ToString();
                lblAltura.Text = "Altura: " + poke.Altura.ToString() + " m";
                lblPeso.Text = "Peso: " + poke.Peso.ToString() + " kg";
                string[] tipos;
                tipos = poke.Tipo.Split(',');
                if (tipos.Length == 3)
                {
                    picBoxTipo1.Image = new Bitmap("../../Pokemons/Tipos/" + tipos[0] + ".png"); toolTip1.SetToolTip(picBoxTipo1, tipos[0]);
                    picBoxTipo2.Image = new Bitmap("../../Pokemons/Tipos/" + tipos[1] + ".png"); toolTip1.SetToolTip(picBoxTipo2, tipos[1]);
                    picBoxTipo3.Image = new Bitmap("../../Pokemons/Tipos/" + tipos[2] + ".png"); toolTip1.SetToolTip(picBoxTipo3, tipos[2]);
                }
                else if (tipos.Length == 2)
                {
                    picBoxTipo1.Image = new Bitmap("../../Pokemons/Tipos/" + tipos[0] + ".png"); toolTip1.SetToolTip(picBoxTipo1, tipos[0]);
                    picBoxTipo2.Image = new Bitmap("../../Pokemons/Tipos/" + tipos[1] + ".png"); toolTip1.SetToolTip(picBoxTipo2, tipos[1]);
                }
                else
                {
                    picBoxTipo1.Image = new Bitmap("../../Pokemons/Tipos/" + tipos[0] + ".png"); toolTip1.SetToolTip(picBoxTipo1, tipos[0]);
                }
                pokemonSelecionado = index;
                AjustaItens();
            }
            catch (Exception)
            {
                
            }
        }

        //Remove o identificador do treinador do pokemon
        private void btnAbandorar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente abandonar seu pokemon?", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in dataGridViewPoke.Rows)
                {
                    if (row.Selected == true)
                    {
                        var i = dataGridViewPoke.Rows[row.Index].HeaderCell.Value;
                        Pokemon poke = pokemons.First(p => p.Id == Convert.ToInt32(i));
                        poke.Treinador = 0;
                        EditarArquivo.AtualizaArquivoPokemon(poke);
                        IniciaPokemons();
                        break;
                    }
                }

            }
        }

        //Exclui o pokemon selecionado
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir seu pokemon?", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in dataGridViewPoke.Rows)
                {
                    if (row.Selected == true)
                    {
                        var i = dataGridViewPoke.Rows[row.Index].HeaderCell.Value;
                        Pokemon poke = pokemons.First(p => p.Id == Convert.ToInt32(i));
                        if(poke.Treinador == 0)
                        {
                            pokemons.Remove(poke);
                            EditarArquivo.ExcluiArquivoPokemon(poke);
                            IniciaPokemons();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Esse pokemon já possui um treinador e não pode ser excluido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                    }
                }

            }
        }

        //Chama o form para edição do pokemon selecionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPoke.Rows)
            {
                if (row.Selected == true)
                {
                    var i = dataGridViewPoke.Rows[row.Index].HeaderCell.Value;
                    Pokemon poke = pokemons.First(p => p.Id == Convert.ToInt32(i));
                    FormEditarPokemon fep = new FormEditarPokemon(poke, this);
                    this.Hide();
                    fep.ShowDialog();
                    this.Show();
                    break;
                }
            }

        }
        //Abre form para Editar Perfil
        private void button1_Click(object sender, EventArgs e)
        {
            formUsuarios fu = new formUsuarios(treinador, this, pokemons);
            this.Hide();
            fu.ShowDialog();
            this.Show();
        }

        //Abre form de treinamento
        private void btnTreinar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPoke.Rows)
            {
                if (row.Selected == true)
                {
                    var i = dataGridViewPoke.Rows[row.Index].HeaderCell.Value;
                    Pokemon poke = pokemons.First(p => p.Id == Convert.ToInt32(i));
                    if (poke.Forca != poke.ForcaMax)
                    {
                        FormTreino ft = new FormTreino(poke, this);
                        this.Hide();
                        ft.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                        MessageBox.Show("Seu pokemon já esta com sua força maxima e não pode mais treinar ", "Atenção", MessageBoxButtons.OK);
                    
                }
            }
        }
    }
}
