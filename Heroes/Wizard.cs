using System;
using Heroes.Interfaces;

namespace Heroes
{
    public class Wizard : Hero, IMagicUser
    {
        public Wizard(string name, int level = 1) : base(name, level) { }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} использует магический щит");
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} произносит заклинание огненного шара");
        }
    }
}
