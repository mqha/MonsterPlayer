using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(1, 100, 10, 1, 0);
            Monster monster = new Monster(1, 100, 5, 1);

            int monsterKilled = 0;

            while (player.Health > 0)
            {
                player.Attack(monster);
                if(monster.Health < 0)
                {
                    monsterKilled++;
                    player.Exp++;

                    if(player.Exp >= player.Level * 10)
                    {
                        player.Level++;
                        player.LevelUp();
                        player.Exp = 0;
                    }

                    Item item = new Item();
                    item.ApplyItem(player);

                    monster = new Monster(player.Level, 10, 10, 1);
                }
                else
                {
                    monster.Attack(player);
                    if(player.Health <= 0)
                    {
                        Console.WriteLine("Ban da chet");
                    }
                    else
                    {
                        Console.WriteLine("Mau cua ban con: " + player.Health);
                    }
                }
            }

            Console.WriteLine("Game Over");
            Console.WriteLine("Quai vat da bi giet: " +  monsterKilled);
            Console.WriteLine("Level cua ban: " + player.Level);
        }
    }
}
