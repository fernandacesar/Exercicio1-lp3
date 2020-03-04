using System;

namespace Ferlipe_exercicio1

{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes =
             {
                "Fernanda Cesar",
                "Fellipe"
            };
            foreach(String nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}
