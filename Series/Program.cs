using Series.Classes;
using System;

namespace Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario().ToUpper();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        ListarSeries();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Programa Finalizado");
            Console.ReadLine();
        }

        private static void VisualizarSerie()
        {
            throw new NotImplementedException();
        }

        private static void ExcluirSerie()
        {
            throw new NotImplementedException();
        }

        private static void AtualizarSerie()
        {
            throw new NotImplementedException();
        }

        private static void InserirSerie()
        {
            throw new NotImplementedException();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries:");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("<<< Nenhuma Série Cadastrada >>>".PadLeft(70).PadRight(90));
                Console.WriteLine("".PadRight(106, '='));
                return;
            }

            else
            {
                foreach (var serie in lista)
                {
                    serie.ToString();
                }
            }

            
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Dio - Séries a Seu Dispor".PadLeft(70).PadRight(90));
            Console.Write(String.Format("Data: {0:dd/MM/yyyy}", DateTime.Today).PadRight(40));
            Console.WriteLine(String.Format("Hora: {0}", DateTime.Now.ToString("hh:mm:ss")).PadLeft(66));
            Console.WriteLine("".PadRight(106, '='));
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Listar Série");
            Console.WriteLine("2 - Inserir Nova Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            return opcaoUsuario;
        }
    }
}
