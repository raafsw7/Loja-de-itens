const int precoPocao = 15;

Console.Write("Quantas moedas você possui? ");
if (!int.TryParse(Console.ReadLine(), out int moedas) || moedas < 0)
{
	Console.WriteLine("Quantidade de moedas inválida.");
	return;
}

Console.Write("Quantas poções deseja comprar? ");
if (!int.TryParse(Console.ReadLine(), out int quantidadePocoes) || quantidadePocoes < 0)
{
	Console.WriteLine("Quantidade de poções inválida.");
	return;
}

int total = quantidadePocoes * precoPocao;

if (moedas >= total)
{
	Console.WriteLine($"Total da compra: R$ {total}");
	Console.WriteLine($"Saldo restante: R$ {moedas - total}");
}
else
{
	Console.WriteLine($"Saldo insuficiente. Você precisa de R$ {total}.");
}
