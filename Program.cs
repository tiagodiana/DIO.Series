using System;
using DIO.Series.Classes;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {

            string optionSelect = "";
            do
            {
                optionSelect = Menu();
                switch(optionSelect)
                {
                    case "1":
                        Console.WriteLine("Listar Series");                            
                        break;
                    case "2":
                        Console.WriteLine("Inserir nova Série");                            
                        break;
                    case "3":
                        Console.WriteLine("Atualizar Série");                          
                        break;
                    case "4":
                        Console.WriteLine("Excluir Série");                         
                        break;
                    case "5":
                        Console.WriteLine("Visualizar Série");  
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                                                
                        break;
                }
            }while(optionSelect != "X");
            
        }


        private static string Menu()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("         MENU DE OPÇÕES DE SERIES        ");
            Console.WriteLine("         INFORME A OPÇÃO DESEJADA        ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir nova Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string select = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return select;
        }
    }
}
