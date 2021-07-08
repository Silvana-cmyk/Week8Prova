using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public enum NameL
    {
        DIVINAZIONE,
        FULMINE,
        TEMPESTA,
        TEMPESTA_OSCURA
    }
    public class WeaponL : Weapon
    {
        public const int divinazioneDamage = 15;
        public const int fulmineDamage = 10;
        public const int tempestaDamage = 8;
        public const int tempestaOscuraDamage = 15;

        public NameL Name { get; set; }
        public int Damage { get { return DamageCalculation(); } }

        private int DamageCalculation()
        {
            int danno = 0;
            switch (Name)
            {
                case NameL.DIVINAZIONE:
                    danno = divinazioneDamage;
                    break;
                case NameL.FULMINE:
                    danno = fulmineDamage;
                    break;
                case NameL.TEMPESTA:
                    danno = tempestaDamage;
                    break;
                case NameL.TEMPESTA_OSCURA:
                    danno = tempestaOscuraDamage;
                    break;
                default:
                    danno = 0;
                    break;
            }
            return danno;
        }
    }
}
