using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Item
    {
        public void ApplyItem(Player player)
        {
            Console.WriteLine("Chon chi so muon nang cap:");
            Console.WriteLine("1. Health");
            Console.WriteLine("2. Damage");
            Console.WriteLine("3. Attack Speed");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    player.Health += (int)(player.Health * 0.05);
                    break;
                case 2:
                    player.Damage += (int)(player.Damage * 0.05);
                    break;
                case 3:
                    player.AttackSpeed += (int)(player.AttackSpeed * 0.05);
                    break;
            }
        }
    }
}
