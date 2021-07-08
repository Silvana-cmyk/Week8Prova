namespace FinalFantasy.Core.Entities
{
    public enum NameS
    {
        ASCIA,
        MAZZA,
        SPADA,
    }
    public class WeaponS : Weapon
    {
        public const int asciaDamage = 8;
        public const int mazzaDamage = 5;
        public const int spadaDamage = 10;

        public NameS Name { get; set; }
        public int Damage { get { return DamageCalculation(); } }


        private int DamageCalculation()
        {
            int danno = 0;
            switch (Name)
            {
                case NameS.ASCIA:
                    danno = asciaDamage;
                    break;
                case NameS.SPADA:
                    danno = spadaDamage;
                    break;
                case NameS.MAZZA:
                    danno = mazzaDamage;
                    break;
                default:
                    danno = 0;
                    break;
            }
            return danno;
        }
    }
}