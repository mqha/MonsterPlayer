using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Human
    {
        public int Level { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int AttackSpeed { get; set; }

        public Human(int level, int health, int damage, int attackSpeed) 
        { 
            Level = level;
            Health = health;
            Damage = damage;
            AttackSpeed = attackSpeed;
        }

        public void Attack(Human target)
        {
            Console.WriteLine("Tấn công!");
            target.Health -= Damage;
            if (target.Health <= 0) 
            {
                Console.WriteLine("Mục tiêu đã bị tiêu diệt");
            }
            else
            {
                Console.WriteLine("Máu quái vật còn lại: "+ target.Health);
            }
        }
    }
}
