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
    public partial class formUsuarios : Form
    {
        private Treinador treinador;
        private FormPrincipal formPrincipal;
        private List<Treinador> treinadores = new List<Treinador>();
        private List<Pokemon> pokemons;

        public formUsuarios(Treinador trein, FormPrincipal form, List<Pokemon> pokemons)
        {
            InitializeComponent();
            treinador = trein;
            this.pokemons = pokemons;
            formPrincipal = form;
            IniciaTreinador();
            CarregaArquivo();
            CompletaGrid();
            dataGridViewPoke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPoke.MultiSelect = false;
        }

        private void IniciaTreinador()
        {
            txtNome.Text = treinador.Nome;
            txtLogin.Text = treinador.Login;
        }

        private void CarregaArquivo()
        {
            StreamReader reader = new StreamReader("../../Save/dadosTreinadores.txt");
            string linha = reader.ReadLine();

            while (linha != null)
            {
                string[] dados;
                dados = linha.Split(';');
                Treinador t1 = new Treinador(Convert.ToInt32(dados[0]), dados[1], dados[2], dados[3]);
                treinadores.Add(t1);
                linha = reader.ReadLine();
            }
            reader.Close();
        }

        private void CompletaGrid()
        {
            int i = 0;
            foreach (Treinador trein in treinadores)
            {
                    dataGridViewPoke.Rows.Add();
                    dataGridViewPoke.Rows[i].HeaderCell.Value = trein.Id.ToString();
                    dataGridViewPoke.Rows[i].Cells[0].Value = trein.Nome;
                i++;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar Perfil")
            {
                MessageBox.Show("Confirme sua senha para poder editar seu perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEditar.Text = "Verificar Senha";
                txtSenha.Text = "";
                txtSenha.ReadOnly = false;
                txtSenha.Focus();
            }
            else if(btnEditar.Text == "Verificar Senha")
            {
                if (txtSenha.Text == treinador.Senha)
                {
                    btnEditar.Text = "Salvar";
                    txtNome.ReadOnly = false;
                    txtLogin.ReadOnly = false;
                    MessageBox.Show("Senha correta, edite suas informações e clique em salvar", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    {
                        btnEditar.Text = "Editar Perfil";
                        txtSenha.ReadOnly = true;
                    }
                    
                }
            }
            else
            {
                Salvar();
            }
            
        }


        private void Salvar()
        {
            try
            {
                treinador.Nome = txtNome.Text;
                treinador.Login = txtLogin.Text;
                treinador.Senha = txtSenha.Text;
                EditarArquivo.AtualizaArquivoTreinador(treinador);
                btnEditar.Text = "Editar Perfil";
                txtLogin.ReadOnly = true;
                txtNome.ReadOnly = true;
                txtSenha.ReadOnly = true;
                MessageBox.Show("Usuario editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void formUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Construtor(treinador);
        }

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
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir seu perfil?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                EditarArquivo.ExcluiArquivoTreinador(treinador);
                foreach(Pokemon poke in pokemons)
                {
                    if (poke.Treinador == treinador.Id)
                    {
                        poke.Treinador = 0;
                        EditarArquivo.AtualizaArquivoPokemon(poke);
                    }
                }
                MessageBox.Show("Treinador excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
        }
    }
}
