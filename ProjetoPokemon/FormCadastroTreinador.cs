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
    public partial class FormCadastroTreinador : Form
    {
        private List<Treinador> treinadores = new List<Treinador>();
        private FormLogin formLogin;

        //Construtor
        public FormCadastroTreinador(List<Treinador> treinadores, FormLogin form)
        {
            InitializeComponent();
            formLogin = form;
            this.treinadores = treinadores;
        }

        //Fecha o Form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metódo para Cadastrar um novo Treinador
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                foreach(Treinador t in treinadores)
                {
                    if (t.Login.Equals(txtLogin.Text))
                    {
                        MessageBox.Show("login indisponivel, por favor tente outro login!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                        
                }

                int id;
                if (treinadores.Count > 0)
                    id = treinadores.Last().Id + 1;
                else
                    id = 1;
                Treinador treinador = new Treinador(id, txtNome.Text, txtLogin.Text, txtSenha.Text);
                treinadores.Add(treinador);
                StreamWriter writer = File.AppendText("../../Save/dadosTreinadores.txt");
                writer.Write(id.ToString()+ ";" + treinador.Nome + ";" + treinador.Login + ";" + treinador.Senha + Environment.NewLine);
                writer.Close();
                formLogin.Contrutor(treinadores);
                MessageBox.Show("Cadastro realizado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
