using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03_11_2021
{
    internal class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares = new List<Exemplar>();

       

        public Livro(int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
        }

        public Livro()
        {
            this.isbn = 0;
            this.titulo = " ";
            this.autor = " ";
            this.editora = " ";
            this.exemplares = new List<Exemplar>();
        }

        public int Isbn { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        internal List<Exemplar> Exemplares { get => exemplares; set => exemplares = value; }

        public void adicionarExemplar(Exemplar exemplar)
        {
            exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            return exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int cont = 0;
            foreach(Exemplar exemplar in exemplares)
            {
                if(exemplar.disponivel())
                {
                    cont++;
                }
                
            }
            return cont;
        }
        public int qtdeEmprestimos()
        {
            int cont = 0;
            foreach (Exemplar exemplar in exemplares)
            {
                cont += exemplar.qtdeEmprestimos();
            }
            return cont;
        }

        public double percDisponibilidade()
        {
            return qtdeDisponiveis() * (100 / qtdeExemplares());
        }
    }
}
