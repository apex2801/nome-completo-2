using System;

namespace nome_completo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome;
            Console.Write("Digite seu primeir nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine($"\n\nNome completo: {nome} {sobrenome}");
            Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");
        }
    }
}
