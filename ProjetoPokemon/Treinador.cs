using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPokemon
{
    public class Treinador
    {
        private string nome;
        private string login;
        private string senha;
        private int id;

        public Treinador(int id, string nome, string login, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
        }

        public Treinador()
        {

        }

        public string Nome { get => nome; set => nome = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Id { get => id; set => id = value; }
    }
}
