using System;

namespace GameManagement
{
    public static class GameSettings
    {
        public static int MaxLevel { get; set; } = 100;

        public static bool IsLevelValid(int level)
        {
            return level <= MaxLevel;
        }
    }
}
