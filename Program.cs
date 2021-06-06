using System;
using DIO.Series.Classes;


namespace DIO.Series
{
    class Program
    {
        private static SerieRepositorio repositorio = new SerieRepositorio();

        private static string optionSelect;
        private static string inputTitulo;
        private static int inputGenero;
        private static int inputAno;
        private static string inputDescricao;


        static void Main(string[] args)
        {
            do
            {
                Menu();
                switch(optionSelect)
                {
                    case "1":
                        ListSeries();                       
                        break;
                    case "2":
                        InsertSeries();                            
                        break;
                    case "3":
                        UpdateSeries();                        
                        break;
                    case "4":
                        DeleteSeries();                        
                        break;
                    case "5":
                        GetSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                                                
                        break;
                }
            }while(optionSelect != "X");
            
        }


        private static void Menu()
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

            optionSelect = Console.ReadLine().ToUpper();
            Console.WriteLine();
        }

        private static void ListSeries()
        {
            var lista = repositorio.List();
            Console.WriteLine("Listar Séries");

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Série cadastrada.");
            }
            else
            {
                foreach (var serie in lista)
                {

                    Console.WriteLine($"#ID {serie.retornaId() + 1}: {serie.retornaTitulo()} {serie.retornaExcluido()}");
                }
                Console.WriteLine();
            }
        }

        private static void GetInputsSeries()
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} {Enum.GetName(typeof(Genero), i)}");
            }

            Console.WriteLine("Digite o genêro entre as opções acima: ");
            inputGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Série: ");
            inputTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Inicio da Série: ");
            inputAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            inputDescricao = Console.ReadLine();
        }

         private static void InsertSeries()
        {
            GetInputsSeries();

            Serie newSerie = new Serie(Id: repositorio.NextId(),
                                        genero: (Genero)inputGenero,
                                        Titulo: inputTitulo,
                                        ano: inputAno,
                                        Descricao: inputDescricao);

            repositorio.Insert(newSerie);

        }

         private static void UpdateSeries()
        {
            var lista = repositorio.List();
            if (lista.Count > 0)
            {
                Console.WriteLine("Digite o ID da Série que deseja Atualizar: ");

                int idSerie = int.Parse(Console.ReadLine()) - 1;

                GetInputsSeries();

                Serie updateSerie = new Serie(Id: idSerie,
                                       genero: (Genero)inputGenero,
                                       Titulo: inputTitulo,
                                       ano: inputAno,
                                       Descricao: inputDescricao);

                repositorio.Update(idSerie, updateSerie);
            }
            else
            {
                Console.WriteLine("Nenhuma Série cadastrada.");
            }
        }

         private static void DeleteSeries()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o ID da Série que deseja DELETAR: ");
            int idSerie = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine(); 
            Console.WriteLine(repositorio.GetById(idSerie));
            Console.WriteLine("Deseja Realmente Excluir essa Série? [S/N]");
            string confirmation = Console.ReadLine().ToUpper();
            if (confirmation == "S")
            {
                repositorio.Delete(idSerie);
            }
        }

        private static void GetSerie()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o ID da Série: ");
            int idSerie = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine();
            Console.WriteLine(repositorio.GetById(idSerie));
            Console.WriteLine();
        }
    }
}
