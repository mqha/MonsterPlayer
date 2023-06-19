using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Human
    {
        private int level;
        private int health;
        private int damage;
        private int atkSpeed;
        private int exp;

        public int Level => level;
        public int Health => health;
        public int Damage => damage;
        public int AttackSpeed => atkSpeed;
        public int Exp => exp;


        public Human()
        {
            this.level = 1;
        }
    }
}
