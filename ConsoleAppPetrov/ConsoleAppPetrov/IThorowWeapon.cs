using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPetrov
{
    public interface IThrowWeapon
    {
        public int ThrowDamage { get; set; }

        public void Throw();
    }
}
