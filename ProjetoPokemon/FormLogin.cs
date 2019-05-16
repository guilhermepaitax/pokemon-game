using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPokemon
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            carregaArquivo();
        }

        //Variável lista de Treinadores
        private List<Treinador> treinadors = new List<Treinador>();

        //Faz a leitura dos dados do arquivo e adiciona em uma lista de objetos de Treinadores
        private void carregaArquivo()
        {
            if (File.Exists("../../Save/dadosTreinadores.txt"))
            {
                StreamReader reader = new StreamReader("../../Save/dadosTreinadores.txt");
                string linha = reader.ReadLine();

                while(linha != null)
                {
                    string[] dados;
                    dados = linha.Split(';');
                    Treinador t1 = new Treinador(Convert.ToInt32(dados[0]), dados[1], dados[2], dados[3]);
                    treinadors.Add(t1);
                    linha = reader.ReadLine();
                }
                reader.Close();
            }
            else
            {
                StreamWriter writer = new StreamWriter("../../Save/dadosTreinadores.txt");
                writer.Close();
            }

            if (!File.Exists("../../Save/dadosPokemons.txt"))
            {
                StreamWriter writer = new StreamWriter("../../Save/dadosPokemons.txt");
                writer.Close();
            }

        }

        //Recebe uma Lista de Treinadores e atualiza a lista existente
        public void Contrutor(List<Treinador> treinadors)
        {
            this.treinadors = treinadors;
        }


        //Chama o Form para o Cadastro de um novo Treinador
        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            ////////////////////////Melhorar////////////////////////
            FormCadastroTreinador fct = new FormCadastroTreinador(treinadors, this);
            this.Hide();
            fct.ShowDialog();
            this.Show();
        }


        //Métódo para valídar o login dos treinadores
        private void Logar()
        {
            int i = 0;

            if (treinadors.Count == 0)
                MessageBox.Show("Login e/ou Senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (Treinador t1 in treinadors)
            {
                i++;
                if (txtLogin.Text.Equals(t1.Login) && txtSenha.Text.Equals(t1.Senha))
                {
                    FormPrincipal fp = new FormPrincipal(t1);
                    Hide();
                    fp.ShowDialog();
                    txtLogin.Clear();
                    txtSenha.Clear();
                    Show();
                    carregaArquivo();
                    break;
                }
                else if (i == treinadors.Count)
                {
                    MessageBox.Show("Login e/ou Senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }
    }
}
