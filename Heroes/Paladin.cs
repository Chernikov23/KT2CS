using System;
using Heroes.Interfaces;

namespace Heroes
{
    public class Paladin : Hero, IMagicUser, IPhysicalFighter
    {
        public Paladin(string name, int level = 1) : base(name, level) { }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} использует божественную защиту");
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} призывает божественное исцеление");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} наносит удар священным молотом");
        }
    }
}
