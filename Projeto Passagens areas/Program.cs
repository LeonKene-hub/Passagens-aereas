//entrar apenas com senha 123456

//exibir menu comas opcoes:
//1 cadastrar passagem
//2 listar passagens
//0 sair

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
    Login();
}

static void Login()
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
        bool logado = true;
    }
    else
    {
        Console.WriteLine($"Senha incorreta!");
        bool logado = false;
    }


}