using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03_11_2021
{
    internal class Livros
    {
        List<Livro> acervo = new List<Livro>();

        public Livros()
        {
            this.acervo = new List<Livro>();
        }

        public Livros(List<Livro> livro)
        {
            this.acervo = livro;
        }

        internal List<Livro> Livro { get => acervo; set => acervo = value; }

        public void adicionar(Livro livro)
        {
            acervo.Add(livro);
        }

        public Livro pesquisar(Livro livro)
        {
            Livro resultado = new Livro();
            foreach ( Livro l in acervo)
            {
                if (l.Isbn == livro.Isbn)
                {
                    resultado = l;
                }
            }
            return resultado;
        }

    }
}
