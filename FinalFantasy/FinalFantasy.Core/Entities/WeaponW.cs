namespace FinalFantasy.Core.Entities
{
    public enum NameW
    {
        ARCO_FRECCE,
        BACCHETTA,
        BASTONE_MAGICO,
    }
    public class WeaponW : Weapon
    {
        public const int arcoFrecceDamage = 8;
        public const int bacchettaDamage = 5;
        public const int bastoneMagicoDamage = 10;

        public NameW Name { get; set; }
        public int Damage { get { return DamageCalculation(); } }


        private int DamageCalculation()
        {
            int danno = 0;
            switch (Name)
            {
                case NameW.ARCO_FRECCE:
                    danno = arcoFrecceDamage;
                    break;
                case NameW.BACCHETTA:
                    danno = bacchettaDamage;
                    break;
                case NameW.BASTONE_MAGICO:
                    danno = bastoneMagicoDamage;
                    break;
                default:
                    danno = 0;
                    break;
            }
            return danno;
        }
    }
}