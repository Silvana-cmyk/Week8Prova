using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryMock
{
    public class RepositoryWeaponMock : IRepositoryWeapon
    {
        ICollection<Weapon> weapons = new List<Weapon>();
        public ICollection<Weapon> GetAll()
        {
            return weapons;
        }
    }
}
