
using ConsoleApp1;

var kombucha = new Produto("Kombucha de Abacaxi - 600ml", 23.99f);
var caixaMorangos = new Produto("Caixa de Morango - 5un", 12.99f);

var laura = new Cliente("docsbylams@gmail.com", "Laura Mariana");

var meuCarrinho = new Carrinho(laura);

meuCarrinho.Adicionar(kombucha);
meuCarrinho.Adicionar(caixaMorangos);

Console.WriteLine("NÃO É NOTA FISCAL - Sistema Lalo™ de Compras\n\n");

laura.ExibirInfo();

Console.WriteLine("----");

foreach (var item in meuCarrinho.Produtos)
{
    Console.WriteLine($"{item.Nome}    R$ {item.Preco}");
}