using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPokemon
{
    public class Pokemon
    {
        private string nome;
        private int id;
        private int forca;
        private int forcaMax;
        private double peso;
        private double altura;
        private int efeito;
        private int defesa;
        private int defesaMax;
        private int vida;
        private string evolucao;
        private string foto;
        private int treinador;
        private string tipo;

        public Pokemon(string nome, int id, double peso, double altura, string evolucao, string foto)
        {
            Random random = new Random();
            this.nome = nome;
            this.id = id;
            this.peso = peso;
            this.altura = altura;
            this.evolucao = evolucao;
            this.foto = foto;
            vida = 100;
            treinador = 0;
            efeito = random.Next(1, 6);
            forca = CalculaForca();
            defesa = CalculaDefesa();
            forcaMax = forca + (forca * (random.Next(7, 16) * 10)) / 100;
            defesaMax = defesa + (defesa * (random.Next(7, 16) * 10)) / 100;
        }

        public Pokemon()
        {

        }

        private int CalculaForca()
        {
            return Convert.ToInt32(Math.Sqrt(altura * peso + efeito));
        }

        private int CalculaDefesa()
        {
            Random random = new Random();
            return Convert.ToInt32(Math.Sqrt(random.Next(1, 6) * peso + altura));

        }

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public int Forca { get => forca; set => forca = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public int Efeito { get => efeito; set => efeito = value; }
        public string Evolucao { get => evolucao; set => evolucao = value; }
        public string Foto { get => foto; set => foto = value; }
        public int Defesa { get => defesa; set => defesa = value; }
        public int Vida { get => vida; set => vida = value; }
        public int Treinador { get => treinador; set => treinador = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int ForcaMax { get => forcaMax; set => forcaMax = value; }
        public int DefesaMax { get => defesaMax; set => defesaMax = value; }
    }
}
