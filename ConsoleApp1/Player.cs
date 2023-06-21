using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player : Human
    {
        public int Exp {get;set;}

        public Player(int level, int health, int damage, int attackSpeed, int exp) : base (level,health,damage,attackSpeed)
        {
            Exp = exp;
        }

        public void LevelUp()
        {
            Console.WriteLine("Level up! Chọn chỉ số muốn nâng cấp");
            Console.WriteLine("1. Health");
            Console.WriteLine("2. Damage");
            Console.WriteLine("3. Attack Speed");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Health += (int)(Health * 0.3);
                    break;
                case 2:
                    Damage += (int)(Damage * 0.3);
                    break;
                case 3:
                    AttackSpeed += (int)(AttackSpeed * 0.3);
                    break;

            }
        }
    }
}
