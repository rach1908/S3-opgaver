using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NAME OF YOUR FIGHTER:");
            string name = Console.ReadLine();
            Warrior w1 = new Warrior(name, 200, 69, 30);
            Console.Clear();
            Console.WriteLine("ENTER THE NAME OF YOUR OPPONENT");
            string name2 = Console.ReadLine();
            Warrior w2 = new Warrior(name2, 200, 80, 15);
            Console.Clear();
            Battle.StartFight(w1, w2);
        }
    }
}
