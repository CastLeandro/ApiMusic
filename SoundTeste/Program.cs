
string mensagemDeBoasVindas = "Boas vindas ao Music Player!";

void ExibirMensagemDeBoasVindas(string mensagem)
{
    Console.WriteLine("*******************--****************");
    Console.WriteLine(mensagem);
    Console.WriteLine("*******************--****************");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 pra registrar uma banda");
    Console.WriteLine("Digite 2 para listar todas as bandas");
    Console.WriteLine("Digite 3 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");
}


ExibirMensagemDeBoasVindas(mensagemDeBoasVindas);
ExibirOpcoesDoMenu();