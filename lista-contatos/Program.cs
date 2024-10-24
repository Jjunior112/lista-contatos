using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_contatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Contatos");
            Console.WriteLine(new string('*', 50));

            List<int> contatos = new List<int>();



            Console.WriteLine("Operações: \n \n 1 - Adicionar contato \n 2 - Remover contato \n 3 - Lista de contatos \n 4 - Finalizar ");

            Console.Write(" Digite uma operação: ");

            int operations = int.Parse(Console.ReadLine());

            void ChooseOp()
            {
                Console.WriteLine("Operações: \n 1 - Adicionar contato \n 2 - Remover contato \n 3 - Lista de contatos \n 4 - Finalizar ");
                Console.Write(" Digite uma operação: ");

                operations = int.Parse(Console.ReadLine());
                while (operations < 1 || operations > 4)
                {
                    Console.Write("Operação inválida! ");
                    Console.WriteLine("Operações: \n 1 - Adicionar contato \n 2 - Remover contato \n 3 - Lista de contatos \n 4 - Finalizar ");
                    Console.Write(" Digite uma operação: ");
                    operations = int.Parse(Console.ReadLine());
                }
            }
            void ShowContact()
            {
                Console.WriteLine("\n \n Contatos ");
                Console.WriteLine(new string('*', 50));

                foreach (int i in contatos)
                {
                    Console.WriteLine($"{i}\n");

                }

                Console.WriteLine(new string('*', 50));
            }

            while (operations != 4)
            {
                switch (operations)
                {
                    case 1:
                        Console.Write("Digite um contato: ");

                        int contato = int.Parse(Console.ReadLine());

                        contatos.Add(contato);

                        ShowContact();

                        ChooseOp();


                        break;

                    case 2:


                        if (contatos.Count > 0)
                        {
                            ShowContact();


                            Console.WriteLine("Escolha o contato que deseja remover");

                            int remove = int.Parse(Console.ReadLine());

                            remove = remove - 1;

                            contatos.Remove(contatos[remove]);

                            ShowContact();
                            ChooseOp();


                        }

                        else
                        {


                            Console.WriteLine("\n \nNão há contatos na lista\n \n");



                            ChooseOp();
                        }


                        break;

                    case 3:
                        ShowContact();
                        ChooseOp();
                        break;

 
                }
               
            }
            Console.WriteLine("\n \n Fechando...");


        }
    }
}
