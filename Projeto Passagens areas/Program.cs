//entrar apenas com senha 123456

//exibir menu comas opcoes:
//1 cadastrar passagem
//2 listar passagens
//0 sair
bool logado = false;
bool menu = false;
string[] nomes = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
int[] data = new int[5];

Console.WriteLine(@$"
-------------------------------------------
|                                         |
|             Seja bem vindo              |
|         a agencia de turismo            |
|              Alem dos Ceus              |
|                                         |
|                                         |
|      pressione ENTER para entrar        |
|                                         |
-------------------------------------------
");

ConsoleKeyInfo entrar = new ConsoleKeyInfo();
entrar = Console.ReadKey();

if (entrar.Key == ConsoleKey.Enter)
{
    logado = Login();
}

//login aqui!
static bool Login()
{
    Console.WriteLine(@$"
---------------------
| Digite sua senha: |
---------------------
    ");

    string senha = Console.ReadLine();
    string senhaCorreta = "chocolate";

    if (senha == senhaCorreta)
    {
        Console.WriteLine($"seja bem vindo(a)");
        return true;
    }
    else
    {
        Console.WriteLine($"Senha incorreta!");
        return false;
    }
}

//validacao de login
do
{
    if (logado == true)
    {
        Console.WriteLine($"Seja bem vindo!");
        menu = true;
    }
    else
    {
        Console.WriteLine($"Tente novamente");
        logado = Login();
    }
} while (logado == false);

//menu
do
{
    Console.WriteLine(@$"
--------------------------
|          Menu          |
|                        |
| (1) Cadastrar passagem |
| (2) Lista de passagens |
| (0) Sair               |
|                        |
--------------------------
");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            bool concluido = false;
            int posicao = 0;

            do
            {
                Console.WriteLine($"Digite seu nome:");
                nomes[posicao] = Console.ReadLine();
                
                Console.WriteLine($"Informe sua origem:");
                origem[posicao] = Console.ReadLine();
                
                Console.WriteLine($"Informe seu destino:");
                destino[posicao] = Console.ReadLine();
                
                Console.WriteLine($"Digite o dia de embarque");
                data[posicao] = int.Parse(Console.ReadLine());

                posicao++;
                Console.WriteLine($"Deseja realizar outro cadastro? (s para sim/ n para nao)");
                string decisao = Console.ReadLine();
                
                if (decisao == "n")
                {
                    concluido = true;
                    menu = true;
                }
                else if (decisao == "s")
                {
                    concluido = false;
                    menu = true;
                }
                else
                {
                    concluido = true;
                    menu = true;
                }
            } while (concluido == false);
            break;

        case 2:
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"{nomes[i]}, {origem[i]}, {destino[i]}, {data[i]}");
                
            }
            break;
        case 0:
            Console.WriteLine($"Sair");
            menu = false;
            break;
        default:
            break;
    }
} while (menu == true);
