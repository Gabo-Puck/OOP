using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diagnostico.Models
{
    public class BaseEntity
    {
        int health { get; set; }
        public int stamina {get; private set;}
        public int attackPower {get;}
        public string name {get;}
        public bool isDead {get; private set;}
        public BaseEntity(string _name,int _attack,int _stamina,int _health){
            name=_name;
            attackPower=_attack;
            stamina=_stamina;
            health=_health;
        }

        public virtual void getExahusted(int _stamina){
            if(stamina<=_stamina)
                stamina = 0;
            else
                stamina -= _stamina;
            printStats();
        }
        public virtual int recieveDamage(int damage){
            if(damage>health){
                health = 0;
                isDead = true;
            }else
                health -= damage;
            printStats();
            return health;
        }

        public virtual void printStats(){
            if(isDead)
                Console.WriteLine($@"{name} is already dead!");
            Console.WriteLine($@"
                Name: {name}
                Health: {health}
                Stamina: {stamina}
            ");
        }
    }
}