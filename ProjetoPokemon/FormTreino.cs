using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPokemon
{
    public partial class FormTreino : Form
    {
        private int Segundos = 0;
        private int Minutos = 0;
        private int Horas = 0;
        private int Progresso = 0;
        private Pokemon pokemon;
        private FormPrincipal formPrincipal;
        public FormTreino(Pokemon pokemon, FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.pokemon = pokemon;
            MessageBox.Show("Aguarde 1 hora para o treinamento ser concluído!", "Aviso");
        }

        private void timerPomba_Tick(object sender, EventArgs e)
        {
            Refresh();


            if (pictureBoxBaixoDir.Left >= 10) //Baixo Direita.
            {
                pictureBoxBaixoDir.Left -= 110;
            }
            else
            {
                pictureBoxBaixoDir.Left = 1099;
            }

            if (pictureBoxBaixoEsq.Left <= 1100) //Baixo Esquerda.
            {
                pictureBoxBaixoEsq.Left += 110;
            }
            else
            {
                pictureBoxBaixoEsq.Left = 10;
            }

            if (pictureBoxAltaDir.Left >= 10) //Alto Direita.
            {
                pictureBoxAltaDir.Left -= 90;
            }
            else
            {
                pictureBoxAltaDir.Left = 1099;
            }

            if (pictureBoxAltaEsq.Left <= 1100) //Alto Esquerda.
            {
                pictureBoxAltaEsq.Left += 90;
            }
            else
            {
                pictureBoxAltaEsq.Left = 10;
            }

            if (pictureBoxMeioDir.Left <= 1099) //Moro&LUla
            {
                pictureBoxMeioEsq.Left += 80;
                pictureBoxMeioDir.Left += 80;
            }
            else
            {
                pictureBoxMeioEsq.Left = 12;
                pictureBoxMeioDir.Left = 130;

            }

        }

        private void timerTreino_Tick(object sender, EventArgs e)
        {
            Refresh();

            Segundos += 1;
            if (Segundos == 60)
            {
                Segundos = 0;
                Minutos += 1;
                if (Minutos == 60)
                {
                    Minutos = 0;
                    Horas += 1;
                }
            }

            if (Segundos <= 9)
            {
                lblSegundos.Text = "0" + Segundos.ToString();
            }
            else
            {
                lblSegundos.Text = Segundos.ToString();
            }
            if (Minutos <= 9)
            {
                lblMinutos.Text = "0" + Minutos.ToString();
            }
            else
            {
                lblMinutos.Text = Minutos.ToString();
            }
            if (Horas <= 9)
            {
                lblHoras.Text = "0" + Horas.ToString();
            }
            else
            {
                lblHoras.Text = Horas.ToString();
            }

            Progresso += 1;
            progressBarTreino.Increment(1);
            progressBarTreino.Value = Progresso;

            if (Horas == 1)
            {
                pictureBoxAltaDir.Visible = false;
                pictureBoxAltaEsq.Visible = false;
                pictureBoxBaixoDir.Visible = false;
                pictureBoxBaixoEsq.Visible = false;
                pictureBoxMeioDir.Visible = false;
                pictureBoxMeioEsq.Visible = false;
                pictureBox1.Visible = true;
                timerPomba.Enabled = false;
                timerTreino.Enabled = false;

                int aumentoF =Convert.ToInt32(pokemon.ForcaMax * 0.1);
                int aumentoD = Convert.ToInt32(pokemon.DefesaMax * 0.1);
                pokemon.Forca += aumentoF;
                pokemon.Defesa += aumentoD;
                if (pokemon.Defesa >= pokemon.DefesaMax)
                {
                    pokemon.DefesaMax = pokemon.Forca;
                }
                if (pokemon.Forca >= pokemon.ForcaMax)
                {
                    pokemon.Nome = pokemon.Evolucao;
                    pokemon.ForcaMax = pokemon.Forca;
                    MessageBox.Show("Seu pokemon evoluiu!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                EditarArquivo.AtualizaArquivoPokemon(pokemon);
                formPrincipal.Construtor(pokemon);
                
                MessageBox.Show("Treino efetuado com sucesso!", "Parábens!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
