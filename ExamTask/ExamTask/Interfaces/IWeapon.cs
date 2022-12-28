using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Interfaces
{
    public interface IWeapon
    {
        public int MagazineCharge { get; set; }

        public int Damage { get; set; }

        public void MultiGun();
    }
}
