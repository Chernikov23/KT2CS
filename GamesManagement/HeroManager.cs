using System;
using Heroes;
using Heroes.Interfaces;

namespace GameManagement
{
    public class HeroManager<T> where T : Hero
    {
        private List<T> heroes = new List<T>();

        public void AddHero(T hero)
        {
            heroes.Add(hero);
            Console.WriteLine($"Герой {hero.Name} добавлен в менедже");
        }

        public void LevelUpHero(string name)
        {
            var hero = heroes.Find(h => h.Name == name);
            if (hero != null)
            {
                if (GameSettings.IsLevelValid(hero.Level + 1))
                {
                    hero.LevelUp();
                }
                else
                {
                    Console.WriteLine($"Невозможно повысить уровень {name}. Достигнут максимальный уровень {GameSettings.MaxLevel}!");
                }
            }
            else
            {
                Console.WriteLine($"Герой с именем {name} не найден");
            }
        }

        public void DisplayHeroes()
        {
            Console.WriteLine("\nСПИСОК ГЕРОЕВ");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"Имя: {hero.Name}, Уровень: {hero.Level}, Тип: {hero.GetType().Name}");
            }
        }

        public void DemonstrateAbilities()
        {
            Console.WriteLine("\nДЕМОНСТРАЦИЯ СПОСОБНОСТЕЙ");
            foreach (var hero in heroes)
            {
                hero.UseAbility();

                if (hero is IMagicUser magicUser)
                {
                    magicUser.CastSpell();
                }
                if (hero is IPhysicalFighter fighter)
                {
                    fighter.Attack();
                }
                Console.WriteLine();
            }
            Console.WriteLine("==================================\n");
        }
    }
}
