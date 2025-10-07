using System;
using Heroes.Interfaces;

namespace Heroes
{
    public class Warrior : Hero, IPhysicalFighter
    {
        public Warrior(string name, int level = 1) : base(name, level) { }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} использует ярость берсерка");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} наносит мощный удар мечом");
        }
    }
}
