using System;
using System.Collections.Generic;
using Heroes;
using GameManagement;

class Program
{
    static void Main(string[] args)
    {
        var wizard = new Wizard("Визард", 10);
        var warrior = new Warrior("Плохой", 15);
        var paladin = new Paladin("Палпатин", 20);

        var heroManager = new HeroManager<Hero>();

        heroManager.AddHero(wizard);
        heroManager.AddHero(warrior);
        heroManager.AddHero(paladin);

        heroManager.DisplayHeroes();

        heroManager.DemonstrateAbilities();

        Console.WriteLine("ПОВЫШЕНИЕ УРОВНЕЙ");
        heroManager.LevelUpHero("Визард");
        heroManager.LevelUpHero("Плохой");
        heroManager.LevelUpHero("Палпатин");
        
        heroManager.LevelUpHero("Неизвестный");

        Console.WriteLine("\nПРОВЕРКА МАКСИМАЛЬНОГО УРОВНЯ");
        var testHero = new Warrior("Тестовый", 100);
        heroManager.AddHero(testHero);
        heroManager.LevelUpHero("Тестовый"); 

        heroManager.DisplayHeroes();

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
