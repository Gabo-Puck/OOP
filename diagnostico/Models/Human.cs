using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diagnostico.Models
{
    public class Human : BaseEntity, IAttack
    {
        int luck {get;set;} = 3;
        public Human(string _name, int _attack, int _stamina, int _health) : base(_name, _attack, _stamina, _health)
        {
        }

        public void attack(BaseEntity enemy)
        {
            if(stamina<=3) throw new Exception($"{name} is exahusted");
            int _attack = isCriticalAttack() ? attackPower + 2: attackPower;
            enemy.recieveDamage(_attack);
            getExahusted(3);
        }
        public bool isCriticalAttack(){
            bool isCritical = new Random().Next(0,luck + 3) > luck;
            if(isCritical)
                Console.WriteLine($"{name} had a lucky strike");
            return isCritical;
        }

        
    }
}