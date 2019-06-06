using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
    class Battle
    {
        static public void StartFight(Warrior w1, Warrior w2)
        {
            bool w1turn = true;
            Console.WriteLine(w1.Name + " vs. " + w2.Name);
            Console.WriteLine("FIGHT!");
            Console.ReadKey(true);
            while (w1.Health > 0 && w2.Health > 0)
            {
                Console.Clear();
                if (w1turn)
                {
                    Console.WriteLine(w1.Name + " attacks " + w2.Name);
                    int att = GetAttackResult(w1, w2);
                    if (att > 0)
                    {
                        Console.WriteLine(w1.Name + " hits " + w2.Name + " for " + att);
                        w2.Health -= att;
                    }
                    else
                    {
                        Console.WriteLine("The attack is blocked");
                    }
                    w1turn = false;
                }
                else
                {
                    Console.WriteLine(w2.Name + " attacks " + w1.Name);
                    int att = GetAttackResult(w2, w1);
                    if (att > 0)
                    {
                        Console.WriteLine(w2.Name + " hits " + w1.Name + " for " + att);
                        w1.Health -= att;
                    }
                    else
                    {
                        Console.WriteLine("The attack is blocked");
                    }
                    w1turn = true;
                }
                Console.WriteLine();
                GetHealthBar(w1, w2);
                Console.ReadKey(true);

            }
            Console.Clear();
            if (w2.Health <= 0)
            {
                Console.WriteLine(w1.Name + " WINS!");
            }
            else
            {
                Console.WriteLine(w2.Name + " WINS!");
            }
            Console.ReadKey(true);
        }

        public static int GetAttackResult(Warrior att, Warrior def)
        {
            return att.Attack() - def.Block();
        }

        public static void GetHealthBar(Warrior w1, Warrior w2)
        {
            double pct1 = double.Parse(w1.Health.ToString()) / double.Parse(w1.MaxHealth.ToString()) * 100;
            double pct2 = double.Parse(w2.Health.ToString()) / double.Parse(w2.MaxHealth.ToString()) * 100;
            string prnt1 = "[";
            string prnt2 = "[";
            for (int i = 1; i <= 100; i+=5)
            {
                if (i < pct1)
                {
                    prnt1 += "#";
                }
                else
                {
                    prnt1 += ".";
                }
            }
            for (int i = 1; i <= 100; i+=5)
            {
                if (i < pct2)
                {
                    prnt2 += "#";
                }
                else
                {
                    prnt2 += ".";
                }
            }
            prnt1 += "]";
            prnt2 += "]";
            Console.WriteLine(w1.Name + ":");
            Console.WriteLine(prnt1);
            Console.WriteLine();
            Console.WriteLine(w2.Name + ":");
            Console.WriteLine(prnt2);

        }
    }
}
