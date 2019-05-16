using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPokemon
{
    static class EditarArquivo
    {
        //Metodo para atualizar linha do pokemon
        public static void AtualizaArquivoPokemon(Pokemon pokeAtualizado)
        {
            try
            {
                StreamReader lendo = new StreamReader("../../Save/dadosPokemons.txt");

                while (lendo.Peek() != -1)
                {

                    int linha = File.ReadAllLines("../../Save/dadosPokemons.txt").GetLength(0);

                    for (int i = 1; i <= linha; i++)
                    {
                        string[] dados = lendo.ReadLine().Split(';');
                        if (dados[0] == pokeAtualizado.Id.ToString())
                        {

                            string caminhoArquivo = "../../Save/dadosPokemons.txt";

                            string[] arquivo = File.ReadAllLines(caminhoArquivo);

                            arquivo[i - 1] = pokeAtualizado.Id + ";" + pokeAtualizado.Nome + ";" + pokeAtualizado.Peso + ";" + pokeAtualizado.Altura + ";"
                                + pokeAtualizado.Evolucao + ";" + pokeAtualizado.Foto + ";" + pokeAtualizado.Vida + ";" + pokeAtualizado.Treinador + ";"
                                + pokeAtualizado.Efeito + ";" + pokeAtualizado.Defesa.ToString() + ";" + pokeAtualizado.Forca.ToString() + ";" + pokeAtualizado.Tipo + ";"
                                + pokeAtualizado.ForcaMax.ToString() + ";" + pokeAtualizado.DefesaMax.ToString();

                            lendo.Close();
                            File.WriteAllLines(caminhoArquivo, arquivo);
                            return;
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Metodo para atualizar linha do treinador
        public static void AtualizaArquivoTreinador(Treinador treiAtualizado)
        {
            try
            {
                StreamReader lendo = new StreamReader("../../Save/dadosTreinadores.txt");

                while (lendo.Peek() != -1)
                {

                    int linha = File.ReadAllLines("../../Save/dadosTreinadores.txt").GetLength(0);

                    for (int i = 1; i <= linha; i++)
                    {
                        string[] dados = lendo.ReadLine().Split(';');
                        if (dados[0] == treiAtualizado.Id.ToString())
                        {

                            string caminhoArquivo = "../../Save/dadosTreinadores.txt";

                            string[] arquivo = File.ReadAllLines(caminhoArquivo);

                            arquivo[i - 1] = treiAtualizado.Id.ToString() + ";" + treiAtualizado.Nome + ";" + treiAtualizado.Login + ";" + treiAtualizado.Senha;

                            lendo.Close();
                            File.WriteAllLines(caminhoArquivo, arquivo);
                            return;
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Remove linha do pokemon do arquivo txt
        public static void ExcluiArquivoPokemon(Pokemon pokeAtualizado)
        {
            
            
            List<string> linhas = File.ReadAllLines("../../Save/dadosPokemons.txt").ToList();
            foreach(string str in linhas)
            {
                string[] dados = str.Split(';');
                if (String.Compare(dados[0], pokeAtualizado.Id.ToString()) == 0)
                {
                    linhas.Remove(str);
                    break;
                }
            }
            
            File.WriteAllLines(("../../Save/dadosPokemons.txt"), linhas.ToArray());
        }

        //Remove linha do treinador do arquivo txt
        public static void ExcluiArquivoTreinador(Treinador treinador)
        {

            List<string> linhas = File.ReadAllLines("../../Save/dadosTreinadores.txt").ToList();
            foreach (string str in linhas)
            {
                string[] dados = str.Split(';');
                if (dados[0] == treinador.Id.ToString())
                {
                    linhas.Remove(str);
                    break;
                }
            }

            File.WriteAllLines(("../../Save/dadosTreinadores.txt"), linhas.ToArray());
        }


    }
}
