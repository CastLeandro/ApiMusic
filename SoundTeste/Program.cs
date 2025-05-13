string mensagemDeBoasVindas = "Boas vindas ao Music Player!";

void ExibirMensagemDeBoasVindas(string mensagem)
{
    Console.WriteLine("*******************--****************");
    Console.WriteLine(mensagem);
    Console.WriteLine("*******************--**************** \n");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 - para registrar uma banda");
    Console.WriteLine("Digite 2 - para listar todas as bandas");
    Console.WriteLine("Digite 3 - para exibir a média de uma banda");
    Console.WriteLine("Digite 0 - para sair \n");

    Console.WriteLine("Digite a sua opção: ");

    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);


    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine($"voce digitou a opcao: {opcao}");
            break;
        case 2:
            Console.WriteLine($"voce digitou a opcao: {opcao}");
            break;
        case 3:
            Console.WriteLine($"voce digitou a opcao: {opcao}");
            break;
        case 0:
            Console.WriteLine($"voce digitou a opcao: {opcao}");
            break;
        default:
            Console.WriteLine("Erro: Opção invál!");
            break;
    }
}


ExibirMensagemDeBoasVindas(mensagemDeBoasVindas);
ExibirOpcoesDoMenu();