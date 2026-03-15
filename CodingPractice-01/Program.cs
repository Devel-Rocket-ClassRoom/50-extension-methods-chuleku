using System;
using System.Linq;

//1. 확장 메서드란? - 정적 메서드 방식
/*string message = "안녕하세요 반갑습니다";
int count = StringHelper.CountWords(message);
Console.WriteLine($"단어 개수: {count}");

public static class StringHelper
{
    public static int CountWords(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}*/

// 2. 확장 메서드란? - 확장 메서드 방식

/*string message = "안녕하세요 반갑습니다";
int count = message.CountWords();
Console.WriteLine($"단어 개수: {count}");*/

/*public static class StringExtensions
{
    public static int CountWords(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}*/

// 3. 숫자 타입 확장

int num1 = 10;
int num2 = 7;

Console.WriteLine($"{num1}은(는) 짝수인가? {num1.IsEven()}");
Console.WriteLine($"{num2}은(는) 홀수인가? {num2.IsOdd()}");
Console.WriteLine($"3을 5번 반복: {3.Repeat(5)}");

public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }

    public static string Repeat(this int number, int times)
    {
        return string.Concat(Enumerable.Repeat(number.ToString(), times));
    }
}