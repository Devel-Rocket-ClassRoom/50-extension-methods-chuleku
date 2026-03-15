using System;

// 1. 간단한 확장 메서드
/*string greeting = "안녕하세요";
Console.WriteLine(greeting.First(3));

public static class StringExtensions
{
    public static string First(this string text, int count)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        if (count >= text.Length)
        {
            return text;
        }

        return text.Substring(0, count);
    }
}
*/

// 2. 사용자 정의 클래스 확장
Player hero = new Player
{
Name = "용사",
Level = 5,
Experience = 150
};

Console.WriteLine(hero.GetInfo());
Console.WriteLine($"레벨업 가능? {hero.CanLevelUp()}");
hero.LevelUp();
Console.WriteLine(hero.GetInfo());

public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
}

public static class PlayerExtensions
{

    public static string GetInfo(this Player player)
    {
        return $"[{player.Name}] 레벨: {player.Level}, 경험치: {player.Experience}";
    }


    public static bool CanLevelUp(this Player player)
    {
        return player.Experience >= 100;
    }

    public static void LevelUp(this Player player)
    {
        if (player.CanLevelUp())
        {
            player.Level++;
            player.Experience -= 100;
            Console.WriteLine($"{player.Name}이(가) 레벨업! 현재 레벨: {player.Level}");
        }
    }
}