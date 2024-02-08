using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace diagnostico.Models
{
    public interface IAttack
    {
        public void attack(BaseEntity enemy);
    }
}