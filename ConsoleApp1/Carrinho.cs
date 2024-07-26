using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Carrinho
    {
        public Cliente Usuario;
        public List<Produto> Produtos;

        public Carrinho(Cliente usuario)
        {
            Usuario = usuario;
            Produtos = new List<Produto>();
        }

        public void Adicionar(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void Remover(Produto produto)
        {
            Produtos.Remove(produto);
        }


    }
}
