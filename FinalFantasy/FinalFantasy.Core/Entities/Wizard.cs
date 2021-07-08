using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public class Wizard : Hero
    {
        public WeaponW Weapon { get; set; }
        public int WeaponID { get; set; }
    }
}
