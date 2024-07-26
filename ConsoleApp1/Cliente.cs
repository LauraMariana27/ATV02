using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cliente
    {
        public string Nome;
        public string Email;

        public Cliente(string email, string nome)
        {
            Nome = nome;
            Email = email;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}\n" +
                $"Email: {Email}");
        }
    }
}
