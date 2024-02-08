using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diagnostico.Models
{
    public class Orc : BaseEntity, IAttack
    {
        int anger {get;set;} = 0;
        int MAX_ANGER = 5;
        public Orc(string _name, int _attack, int _stamina, int _health) : base(_name, _attack, _stamina, _health)
        {
        }

        public void attack(BaseEntity enemy)
        {
            if(stamina<=3) throw new Exception($"{name} is exahusted");
            if(enemy.isDead) return;
            int _attack = attackPower + anger;
            int healthLeft = enemy.recieveDamage(_attack);
            if(healthLeft==0) setAnger(anger+1);
            getExahusted(3);

        }

        public void setAnger(int _anger){
            if(anger >= MAX_ANGER)
                anger = MAX_ANGER;
            anger = _anger;
        }

    }
}