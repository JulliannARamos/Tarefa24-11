using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Ana", 0.0);
            Juridica bacc = new Juridica(1002, "Laura", 0.0, 500.0);

            //UPCASTING

            Conta acc1 = bacc;
            Conta acc2 = new Juridica(1003, "Amelie", 0.0, 500.0);
            Conta acc3 = new Poupanca(1004, "Julia", 0.0, 0.01);

            //DOWNCASTING

            Juridica acc4 = (Juridica)acc2;
            acc4.Emprestimo(100);

            if (acc3 is Juridica)
            {
                Juridica acc5 = (Juridica)acc3;
                acc5.Emprestimo(200);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is Poupanca)
            {
                Poupanca acc5 = acc3 as Poupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}
