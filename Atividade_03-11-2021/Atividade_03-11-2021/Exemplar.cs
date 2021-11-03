using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03_11_2021
{
    internal class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        public Exemplar()
        {
            this.tombo = 0;
            this.emprestimos = new List<Emprestimo>();
        }

        public Exemplar(int tombo)
        {
            this.tombo = tombo;
        }

        public int Tombo { get => tombo; set => tombo = value; }
        internal List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }


        public bool emprestar()
        {
            bool ok = false;
            if (disponivel())
            {
                Emprestimo add = new Emprestimo(DateTime.Now, DateTime.MinValue);
                emprestimos.Add(add);
                ok = true;
            }
            else
            {
                ok = false;
            }
            Emprestimo b = emprestimos.Last();
            return ok;
        }

        public bool devolver()
        {
            bool ok = false;
            if (disponivel())
            {
                ok = false;
            }
            else
            {
                Emprestimo a = emprestimos.Last();
                a.DtDevolucao = DateTime.Now;
                ok = true;
            }
            Emprestimo b = emprestimos.Last();
            return ok;
        }

        public bool disponivel()
        {
            bool ok = false;
            if (Emprestimos.Count() > 0)
            {
                Emprestimo a = emprestimos.Last();
                if (a.DtDevolucao == DateTime.MinValue)
                {
                    ok = false;
                }
                else
                {
                    ok = true;
                }
            }
            else
            {
                ok = true;
            }
            return ok;
        }

        public int qtdeEmprestimos()
        {

            return emprestimos.Count();
        }
    }
}
