using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public abstract class Monster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public Level Level { get; set; }
        public int LevelID { get; set; }
    }
}
