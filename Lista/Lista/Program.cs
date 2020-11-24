using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> minhaLista;
            minhaLista = new List<int>() ; //Criando lista
           //Adicionar == add
            minhaLista.Add(10);
            minhaLista.Add(20);
            minhaLista.Add(30);
            minhaLista.Insert(2, 22); //Insere um item em uma posição especifica. 

            
            Console.WriteLine("Quantos elesmentos na minha lista: " + minhaLista.Count); // Vê quantos elementos da lista.
            Console.WriteLine("-------------------------");

            minhaLista.RemoveAt(3); //Remover item especifico
                                    //Sabendo que ainda existe o RemoveAll(Remove determinado elemento da lista), Remove(elementos da lista),e RemoveRange(Remove elementos da lista a partir da posição e quantos elementos), optei para usar apenas o AT

            
            //loop
            foreach (int item in minhaLista)
            {
                Console.WriteLine(item); 

            }
            
            
            
            Console.ReadKey(); 




        }
    }
}

