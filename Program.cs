using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyStack_Donner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Benutzerdefinierte MeineStack
            MeineStack<int> meinStack = new MeineStack<int>();

            // Stopwatch für benutzerdefinierten Stack
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            for (int i = 0; i < 1000000; i++)
            {
                meinStack.Push(i);
            }

            stopwatch1.Stop();
            Console.WriteLine($"Benutzerdefinierter Stack - Zeit zum Hinzufügen von 1 Million Elementen: {stopwatch1.ElapsedMilliseconds} ms");

            // Eingebaute Stack
            Stack<int> eingebauterStack = new Stack<int>();
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            for (int i = 0; i < 1000000; i++)
            {
                eingebauterStack.Push(i);
            }

            stopwatch2.Stop();
            Console.WriteLine($"Eingebauter Stack - Zeit zum Hinzufügen von 1 Million Elementen: {stopwatch2.ElapsedMilliseconds} ms");

            // Vergleich der Peeks
            int benutzerdefinierterPeek;
            int eingebauterPeek;

            stopwatch1.Restart();
            benutzerdefinierterPeek = meinStack.Peek();
            stopwatch1.Stop();

            stopwatch2.Restart();
            eingebauterPeek = eingebauterStack.Peek();
            stopwatch2.Stop();

            Console.WriteLine($"Benutzerdefinierter Stack - Zeit zum Peek: {stopwatch1.ElapsedMilliseconds} ms");
            Console.WriteLine($"Eingebauter Stack - Zeit zum Peek: {stopwatch2.ElapsedMilliseconds} ms");

            Console.WriteLine($"Benutzerdefinierter Peek: {benutzerdefinierterPeek}");
            Console.WriteLine($"Eingebauter Peek: {eingebauterPeek}");

            Console.ReadKey();
        }
    }
    
}
