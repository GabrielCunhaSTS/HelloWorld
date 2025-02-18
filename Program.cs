Console.WriteLine("Início do programa...");
Console.WriteLine("Seja bem-vindo(a) ao AntaresShoope");

Console.Write("Digite um número: ");
double Desc = double.Parse(Console.ReadLine());
Console.WriteLine($"Você recebeu {Desc}% de desconto!");

Desc = Desc / 100;

Console.Write("Digite o valor do produto que você deseja: ");
double prod = double.Parse(Console.ReadLine());

prod *= (1 - Desc); 
// prod = prod - (prod * Desc);

Console.WriteLine($"O produto que você deseja está saindo por R${prod:F2}!");
Console.Write("Você deseja continuar sua compra? ");
string esc = Console.ReadLine().ToUpper();

if (esc != "SIM" && esc != "S")
{
    Console.WriteLine("Tudo bem, tenha um bom dia!");
}
else
{
    Console.WriteLine("Muito bem!!");
    Console.Write("Selecione a forma de pagamento (D) - Débito, (C) - Crédito, (P) - Pix: ");
    string formapagamento = Console.ReadLine().ToUpper();

    if (formapagamento == "D" || formapagamento == "C")
    {
        Console.WriteLine($"{(formapagamento == "D" ? "Débito" : "Crédito")} selecionado");

        int senhaCorreta = 2018;
        int tentativasRestantes = 3;

        while (tentativasRestantes > 0)
        {
            Console.Write("Digite sua senha: ");
            int senhaDigitada = int.Parse(Console.ReadLine());

            if (senhaDigitada == senhaCorreta)
            {
                Console.WriteLine("Senha correta!"); 
                Console.WriteLine("Pagamento aprovado");
                break;
            }
            else
            {
                tentativasRestantes--;
                Console.WriteLine($"Senha incorreta! Tentativas restantes: {tentativasRestantes}");

                if (tentativasRestantes == 0)
                {
                    Console.WriteLine("Cartão bloqueado!");
                    Console.WriteLine("Entre em contato com o banco");
                    Environment.Exit(1);
                }
            }
        }
    }
    else if (formapagamento == "P")
    {
        Console.WriteLine("Pix selecionado");
        Console.Write("Digite a chave Pix: ");
        string chavePix = Console.ReadLine();

        if (chavePix.Length < 6)
        {
            string mensagemErro = $"Erro: Chave Pix inválida - {chavePix} ({DateTime.Now})";
            Console.WriteLine(mensagemErro);
            File.AppendAllText("log.txt", mensagemErro + Environment.NewLine);
        }
        else
        {
            Console.WriteLine("Pagamento via Pix realizado com sucesso!");
        }
    }
    else
    {
        Console.WriteLine("Opção inválida!");
        Environment.Exit(1);
    }

    Environment.Exit(0);
}
