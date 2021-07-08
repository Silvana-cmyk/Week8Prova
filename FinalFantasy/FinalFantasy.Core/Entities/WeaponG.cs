using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public enum NameG
    {
        ARCO,
        CLAVA
    }
    public class WeaponG : Weapon
    {
        public const int arcoDamage = 7;
        public const int clavaDamage = 5;

        public NameG Name { get; set; }
        public int Damage { get { return DamageCalculation(); } }

        private int DamageCalculation()
        {
            int danno = 0;
            switch (Name)
            {
                case NameG.ARCO:
                    danno = arcoDamage;
                    break;
                case NameG.CLAVA:
                    danno = clavaDamage;
                    break;
                default:
                    danno = 0;
                    break;
            }
            return danno;
        }
    }
}
