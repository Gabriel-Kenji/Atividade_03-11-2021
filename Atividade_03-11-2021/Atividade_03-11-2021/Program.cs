using System;
using System.Collections.Generic;
using System.Linq;

namespace Atividade_03_11_2021 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            
            Exemplar e = new Exemplar(1);

            e.emprestar();
            e.devolver();
            e.emprestar();
            Console.WriteLine(e.qtdeEmprestimos());

            Exemplar e2 = new Exemplar(2);
            e2.emprestar();
            e2.devolver();
            Exemplar e3 = new Exemplar(3);
            Console.WriteLine("1----------------");
            Livro livr = new Livro(1,"a", "b", "c");


            livr.adicionarExemplar(e);
            livr.adicionarExemplar(e2);
            livr.adicionarExemplar(e3);
            Console.WriteLine(livr.qtdeExemplares());
            Console.WriteLine(livr.qtdeDisponiveis());
            Console.WriteLine(livr.qtdeEmprestimos());
            Console.WriteLine(livr.percDisponibilidade()+"%");

            Livros livros = new Livros();

            livros.adicionar(livr);
            Livro p = new Livro(1,"", "", "");
            Livro a1 = livros.pesquisar(p);
            Console.WriteLine(a1.Isbn);
            Console.WriteLine(a1.Titulo);
            Console.WriteLine(a1.Autor);
            Console.WriteLine(a1.Editora);*/


            Livros livros = new Livros();

            int i = -1;
            while (i != 0)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("| 0.Sair                             |");
                Console.WriteLine("| 1.Adicionar livro                  |");
                Console.WriteLine("| 2.Pesquisar livro (sintético)      |");
                Console.WriteLine("| 3.Pesquisar livro (analítico)      |");
                Console.WriteLine("| 4.Adicionar exemplar               |");
                Console.WriteLine("| 5.Registrar  empréstimo            |");
                Console.WriteLine("| 6.Registrar devolução              |");
                Console.WriteLine("--------------------------------------");

                string switc = Console.ReadLine();
                if (switc.All(char.IsDigit))
                {
                    i = Convert.ToInt32(switc);


                    switch (i)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine("\nPrograma finalizado!\n\n");
                            break;


                        case 1:

                            Console.WriteLine("_________________ Adicionar Livros _________________");
                            int a = -1;
                            int isbn = 0;
                            while (a == -1)
                            {
                                a = 0;
                                
                                Console.WriteLine("Digite o numero do isbn do livro:");
                                string num = Console.ReadLine();
                                if (num.All(char.IsDigit))
                                {
                                    isbn = Convert.ToInt32(num);
                                    foreach (Livro livro in livros.Livro)
                                    {
                                        if (livro.Isbn == isbn)
                                        {
                                            a = -1;
                                        }
                                    }
                                    if (a == -1)
                                    {
                                        Console.WriteLine("Isbn já existe! Digite um valido");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ERRO! Digite um numero");
                                    a = -1;
                                }


                            }
                            Console.WriteLine("Digite o titulo do livro:");
                            string titulo = Console.ReadLine();
                            Console.WriteLine("Digite o nome do Autor do livro:");
                            string autor = Console.ReadLine();
                            Console.WriteLine("Digite o nome da Editora do livro");
                            string editora = Console.ReadLine();

                            Livro li = new Livro(isbn,titulo,autor, editora);
                            livros.adicionar(li);
                            Console.WriteLine("Livro adicionado!!!");

                        break;

                        case 2:
                            Console.WriteLine("_________________ Pesquisar Livros (sintético) _________________");
                            int a2 = -1;
                            int isbn1 = 0;
                            while (a2 == -1)
                            {
                                Console.WriteLine("Digite o isbn do livro que deseja procurar:");
                                string pes = Console.ReadLine();
                                if (pes.All(char.IsDigit))
                                {
                                    isbn1 = Convert.ToInt32(pes);
                                    a2 = 0;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO! Digite um numero");
                                }
                            }
                            Livro l = new Livro();
                            foreach(Livro livro in livros.Livro)
                            {
                                if(livro.Isbn == isbn1)
                                {
                                    l = livro;
                                }
                            }
                            Console.WriteLine("Isbn: " + l.Isbn);
                            Console.WriteLine("Titulo: " + l.Titulo);
                            Console.WriteLine("Autor: " + l.Autor);
                            Console.WriteLine("Editora: " + l.Editora);
                            Console.WriteLine("Total de exemplares: " + l.qtdeExemplares());
                            Console.WriteLine("Disponíveis: " + l.qtdeDisponiveis());
                            Console.WriteLine("Total de emprestimos: " + l.qtdeExemplares());
                        break;

                        case 3:
                            Console.WriteLine("_________________ Pesquisar Livros (sintético) _________________");
                            int a3 = -1;
                            int isbn2 = 0;
                            while (a3 == -1)
                            {
                                Console.WriteLine("Digite o isbn do livro que deseja procurar:");
                                string pes1 = Console.ReadLine();
                                if (pes1.All(char.IsDigit))
                                {
                                    isbn2 = Convert.ToInt32(pes1);
                                    a3 = 0;
                                }
                                else
                                {
                                    Console.WriteLine("ERRO! Digite um numero");
                                }
                            }
                            Livro l1 = new Livro();
                            foreach (Livro livro in livros.Livro)
                            {
                                if (livro.Isbn == isbn2)
                                {
                                    l1 = livro;
                                }
                            }
                            Console.WriteLine("Isbn: " + l1.Isbn);
                            Console.WriteLine("Titulo: " + l1.Titulo);
                            Console.WriteLine("Autor: " + l1.Autor);
                            Console.WriteLine("Editora: " + l1.Editora);
                            Console.WriteLine("Total de exemplares: " + l1.qtdeExemplares());
                            Console.WriteLine("Disponíveis: " + l1.qtdeDisponiveis());
                            Console.WriteLine("Total de emprestimos: " + l1.qtdeExemplares());
                            foreach(Exemplar exemplar in l1.Exemplares)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Numero Tombo: " +exemplar.Tombo);
                                Console.WriteLine("Quantidade de emprestimos: " + exemplar.qtdeEmprestimos());
                                Console.WriteLine("Lista de emprestimos:");
                                foreach(Emprestimo emprestimo in exemplar.Emprestimos)
                                {
                                    Console.WriteLine("Data de emprestimo: " + emprestimo.DtEmprestimo + " - Data de devolução: "+ emprestimo.DtDevolucao);
                                }
                            }

                        break;

                        case 4:
                            int a4 = -1;
                            int isbn3 = 0;
                            Livro tomb = new Livro();
                            while (a4 == -1)
                            {
                                Console.WriteLine("Digite o isbn do livro ao qual deseja adicionar um exemplar:");
                                string pes2 = Console.ReadLine();
                                if (pes2.All(char.IsDigit))
                                {
                                    isbn3 = Convert.ToInt32(pes2);
                                    foreach(Livro livro3 in livros.Livro)
                                    {
                                        if (livro3.Isbn == isbn3)
                                        {
                                            a4 = 0;
                                        }
                                        tomb = livro3;
                                    }
                                    if(a4 == -1)
                                    {
                                        Console.WriteLine("Livro escolhido não existe!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ERRO! Digite um numero");
                                }
                            }
                            a4 = -1;
                            int tombo = 0;
                            while (a4 == -1)
                            {
                                Console.WriteLine("Digite o nuemro do tombo do exemplar que deseja adicionar:");
                                string pes3 = Console.ReadLine();
                                if (pes3.All(char.IsDigit))
                                {
                                    tombo = Convert.ToInt32(pes3);
                                    a4 = 0;
                                    foreach (Exemplar exemplar in tomb.Exemplares)
                                    {
                                        if (tombo == exemplar.Tombo)
                                        {
                                            Console.WriteLine("Este Tombo já existe para este livro!");
                                            a4 = -1;
                                        }
                                        
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ERRO! Digite um numero");
                                }
                                
                            }
                            Exemplar ex = new Exemplar(tombo);
                            tomb.adicionarExemplar(ex);
                            Console.WriteLine("Exemplar adicionado com sucesso");

                        break;

                            
                            

                        case 5:
                            int a5 = -1;
                            int isbn4 = 0;
                            Livro tomb1 = new Livro();
                            while (a5 == -1)
                            {
                                Console.WriteLine("Digite o isbn do livro ao qual deseja adicionar um exemplar:");
                                string pes4 = Console.ReadLine();
                                if (pes4.All(char.IsDigit))
                                {
                                    isbn4 = Convert.ToInt32(pes4);
                                    foreach (Livro livro4 in livros.Livro)
                                    {
                                        if (livro4.Isbn == isbn4)
                                        {
                                            a5 = 0;
                                        }
                                        tomb1 = livro4;
                                    }
                                    if (a5 == -1)
                                    {
                                        Console.WriteLine("Livro escolhido não existe!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ERRO! Digite um numero");
                                }
                            }

                            a5 = -1;
                            int tombo1 = 0;
                            Exemplar exemplar1 = new Exemplar();
                            while (a5 == -1)
                            {
                                Console.WriteLine("Digite o nuemro do tombo do exemplar que deseja adicionar:");
                                string pes5 = Console.ReadLine();
                                if (pes5.All(char.IsDigit))
                                {
                                    tombo1 = Convert.ToInt32(pes5);
                                    foreach (Exemplar exemplar in tomb1.Exemplares)
                                    {
                                        if (tombo1 == exemplar.Tombo)
                                        {
                                            exemplar1 = exemplar;
                                            a5 = 0;
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ERRO! Digite um numero");
                                }

                            }
                            if (exemplar1.emprestar())
                            {
                                Console.WriteLine("Emprestimo realizado com sucesso!!");
                            }
                            else
                            {
                                Console.WriteLine("O livro não pode ser emprestado!!");
                            }
                            break;

                        case 6:
                            int a6 = -1;
                            int isbn5 = 0;
                            Livro tomb2 = new Livro();
                            while (a6 == -1)
                            {
                                Console.WriteLine("Digite o isbn do livro ao qual deseja adicionar um exemplar:");
                                string pes6 = Console.ReadLine();
                                if (pes6.All(char.IsDigit))
                                {
                                    isbn5 = Convert.ToInt32(pes6);
                                    foreach (Livro livro5 in livros.Livro)
                                    {
                                        if (livro5.Isbn == isbn5)
                                        {
                                            a6 = 0;
                                        }
                                        tomb2 = livro5;
                                    }
                                    if (a6 == -1)
                                    {
                                        Console.WriteLine("Livro escolhido não existe!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ERRO! Digite um numero");
                                }
                            }

                            a6 = -1;
                            int tombo2 = 0;
                            Exemplar exemplar2 = new Exemplar();
                            while (a6 == -1)
                            {
                                Console.WriteLine("Digite o numero do tombo do exemplar que deseja adicionar:");
                                string pes7 = Console.ReadLine();
                                if (pes7.All(char.IsDigit))
                                {
                                    tombo2 = Convert.ToInt32(pes7);
                                    foreach (Exemplar exemplar in tomb2.Exemplares)
                                    {
                                        if (tombo2 == exemplar.Tombo)
                                        {
                                            exemplar2 = exemplar;
                                            a6 = 0;
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ERRO! Digite um numero");
                                }

                            }
                            if (exemplar2.devolver())
                            {
                                Console.WriteLine("Devolução realizado com sucesso!!");
                            }
                            else
                            {
                                Console.WriteLine("O livro não pode ser devolvido!!");
                            }
                            break;


                    }
                }
                

            }





        }
    }
}