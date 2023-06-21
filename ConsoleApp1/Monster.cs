using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Monster : Human
    {
        public Monster(int level, int health, int damage, int attackSpeed) : base(level, health, damage, attackSpeed)
        {

        }
    }
}
