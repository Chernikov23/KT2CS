using System;

namespace Heroes
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }

        protected Hero(string name, int level = 1)
        {
            Name = name;
            Level = level;
        }

        public abstract void UseAbility();

        public virtual void LevelUp()
        {
            Level++;
            Console.WriteLine($"{Name} повысил уровень, tеперь уровень {Level}");
        }
    }
}

