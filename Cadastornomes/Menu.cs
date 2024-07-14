using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cadastornomes
{
    class Menu
    {
        private Dictionary<string, int> _pessoas = new Dictionary<string, int> {
            { "Teste", 10}
       };

        public void MenuPricipal()
        {
            Console.WriteLine(".##.....##.########.##....##.##.....##\r\n.###...###.##.......###...##.##.....##\r\n.####.####.##.......####..##.##.....##\r\n.##.###.##.######...##.##.##.##.....##\r\n.##.....##.##.......##..####.##.....##\r\n.##.....##.##.......##...###.##.....##\r\n.##.....##.########.##....##..#######.");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1- Cadastrar pessoa \n" +
                "2 -Deletar pessoa\n" +
                "3- Buscar pessoa\n" +
                "0- Sair");

            Console.WriteLine("Digite o numero da função: ");
            selecao();
        }

        private void selecao()
        {
            char direcao = Console.ReadKey().KeyChar;

            switch (direcao)
            {
                case '1':
                    MenucadastrarPessoa();
                    break;
                case '2':
                    MenudeletarPessoa();
                    break;
                case '3':
                    MenubuscarPessoa();
                    break;
                case '0':
                    return;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Digite uma das opções validas");
                    MenuPricipal();
                    break;
            }
        }
        private void MenucadastrarPessoa()
        {
            Console.Clear();
            Console.WriteLine("   ██████      ██     ███████       ██      ████████ ██████████ ███████       ██     ███████  \r\n  ██░░░░██    ████   ░██░░░░██     ████    ██░░░░░░ ░░░░░██░░░ ░██░░░░██     ████   ░██░░░░██ \r\n ██    ░░    ██░░██  ░██    ░██   ██░░██  ░██           ░██    ░██   ░██    ██░░██  ░██   ░██ \r\n░██         ██  ░░██ ░██    ░██  ██  ░░██ ░█████████    ░██    ░███████    ██  ░░██ ░███████  \r\n░██        ██████████░██    ░██ ██████████░░░░░░░░██    ░██    ░██░░░██   ██████████░██░░░██  \r\n░░██    ██░██░░░░░░██░██    ██ ░██░░░░░░██       ░██    ░██    ░██  ░░██ ░██░░░░░░██░██  ░░██ \r\n ░░██████ ░██     ░██░███████  ░██     ░██ ████████     ░██    ░██   ░░██░██     ░██░██   ░░██\r\n  ░░░░░░  ░░      ░░ ░░░░░░░   ░░      ░░ ░░░░░░░░      ░░     ░░     ░░ ░░      ░░ ░░     ░░ ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            cadastrarPessoa(nome, idade);

        }
        private void MenudeletarPessoa()
        {
            Console.Clear();
            Console.WriteLine(" ███████            ██           ██                   \r\n░██░░░░██          ░██          ░██                   \r\n░██    ░██  █████  ░██  █████  ██████  ██████   ██████\r\n░██    ░██ ██░░░██ ░██ ██░░░██░░░██░  ░░░░░░██ ░░██░░█\r\n░██    ░██░███████ ░██░███████  ░██    ███████  ░██ ░ \r\n░██    ██ ░██░░░░  ░██░██░░░░   ░██   ██░░░░██  ░██   \r\n░███████  ░░██████ ███░░██████  ░░██ ░░████████░███   \r\n░░░░░░░    ░░░░░░ ░░░  ░░░░░░    ░░   ░░░░░░░░ ░░░    ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");
            Console.Write("Digite o nome da pessoa que quer deletar: ");
            string nome = Console.ReadLine();
            deletarPessoa(nome);

        }
        private void MenubuscarPessoa()
        {
            Console.Clear();
            Console.WriteLine(" ██████                                           \r\n░█░░░░██                                          \r\n░█   ░██  ██   ██  ██████  █████   ██████   ██████\r\n░██████  ░██  ░██ ██░░░░  ██░░░██ ░░░░░░██ ░░██░░█\r\n░█░░░░ ██░██  ░██░░█████ ░██  ░░   ███████  ░██ ░ \r\n░█    ░██░██  ░██ ░░░░░██░██   ██ ██░░░░██  ░██   \r\n░███████ ░░██████ ██████ ░░█████ ░░████████░███   \r\n░░░░░░░   ░░░░░░ ░░░░░░   ░░░░░   ░░░░░░░░ ░░░    ");
            Console.WriteLine("-----------------------------------------------------------------------------------\n");
            Console.Write("Digite o nome da pessoa que quer buscar: ");
            string nome = Console.ReadLine();
            buscarPessoa(nome);
        }
        private void buscarPessoa(string nome)
        {
            Console.Clear();
            if (_pessoas.ContainsKey(nome))
            {
                Console.WriteLine("Pessoa encontrada!\n");
                Console.WriteLine($"Nome: {nome}\n" +
                    $"Idade: {_pessoas[nome]}\n\n");
                switch (Controlefinal())
                {
                    case '1':
                        MenubuscarPessoa();
                        break;
                    case '2':
                        Console.Clear();
                        MenuPricipal();
                        break;
                    default:
                        return;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada!\n");
                switch (Controlefinal())
                {
                    case '1':
                        MenubuscarPessoa();
                        break;
                    case '2':
                        Console.Clear();
                        MenuPricipal();
                        break;
                    default:
                        return;
                        break;
                }
            }
        }
            private void cadastrarPessoa(string nome, int idade)

            {

                Console.WriteLine("Deseja realmente cadastrar?: ");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);


                if (ControleBinario() == 's')
                {
                    _pessoas.Add(nome, idade);
                }
                else
                {
                    MenucadastrarPessoa();
                }

                Console.Clear();
                Console.WriteLine("Pessoa cadastrada om sucesso!!!");

                char final = Controlefinal();

                switch (final)
                {
                    case '1':
                        MenucadastrarPessoa();
                        break;
                    case '2':
                        Console.Clear();
                        MenuPricipal();
                        break;
                    default:
                        return;
                        break;
                }


            }
            private void deletarPessoa(string nome)
            {
                Console.Clear();

                if (_pessoas.ContainsKey(nome))
                {
                    Console.WriteLine("Deseja realmente deletar?: ");
                    Console.WriteLine("Nome: " + nome);
                    Console.WriteLine("Idade: " + _pessoas[nome]);

                    if (ControleBinario() == 's')
                    {
                        Console.Clear();
                    _pessoas.Remove(nome);
                        Console.WriteLine("Usuário deletado com sucesso!!!\n" +
        "------------------------------------------------");
                    }
                    else
                    {
                        MenudeletarPessoa();
                    }
                }
                else
                {
                    Console.WriteLine("Esse usuário não está cadastrado\n" +
                        "------------------------------------------------");
                    switch (Controlefinal())
                    {
                        case '1':
                            MenudeletarPessoa();
                            break;
                        case '2':
                            Console.Clear();
                            MenuPricipal();
                            break;
                        default:
                            return;
                            break;
                    }
                }

                char final = Controlefinal();

                switch (final)
                {
                    case '1':
                        MenudeletarPessoa();
                        break;
                    case '2':
                        Console.Clear();
                        MenuPricipal();
                        break;
                    default:
                        return;
                        break;
                }
            }

            private char ControleBinario()
            {

                Console.WriteLine("digite 's' ou 'n': ");


                char controle = Console.ReadKey().KeyChar;

                return controle;
            }

            private char Controlefinal()
            {
                Console.WriteLine("Deseja continuar?\n" +
                    "1 - Repetir ação\n" +
                    "2 - Voltar ao menu principal\n" +
                    "3 - Encerrar programa");

                Console.WriteLine("Digite o numero para a ação desejada");
                char controle = Console.ReadKey().KeyChar;

                return controle;
            }
        }
    }

