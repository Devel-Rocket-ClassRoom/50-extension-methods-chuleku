using System;
using System.Collections.Generic;

// 1. 문자열 타입 확장
/*string word = "hello";
Console.WriteLine($"'{word}' 대문자로 시작? {word.IsCapitalized()}");
Console.WriteLine($"첫 글자 대문자: {word.Capitalize()}");
Console.WriteLine($"뒤집기: {word.Reverse()}");

public static class StringExtensions
{
    public static bool IsCapitalized(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false;
        }
        return char.IsUpper(text[0]);
    }

    public static string Capitalize(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        return char.ToUpper(text[0]) + text.Substring(1).ToLower();
    }

    public static string Reverse(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}*/

// 2. 메서드 체이닝
/*string original = "안녕하세요 반갑습니다 좋은 하루 되세요";
string result = original
    .Take(10)
    .AddEllipsis()
    .AddPrefix("[메시지] ")
    .AddSuffix(" (더보기)");

Console.WriteLine($"원본: {original}");
Console.WriteLine($"결과: {result}");

public static class StringChainExtensions
{
    public static string AddPrefix(this string text, string prefix)
    {
        return prefix + text;
    }

    public static string AddSuffix(this string text, string suffix)
    {
        return text + suffix;
    }

    public static string Take(this string text, int count)
    {
        if (string.IsNullOrEmpty(text) || count >= text.Length)
        {
            return text;
        }
        return text.Substring(0, count);
    }

    public static string AddEllipsis(this string text)
    {
        return text + "...";
    }
}*/
// 3. 컬렉션 확장
string[] names = { "철수", "영희", "민수" };
List<int> emptyList = new List<int>();

Console.WriteLine($"names 비어있음? {names.IsEmpty()}");
Console.WriteLine($"emptyList 비어있음? {emptyList.IsEmpty()}");
Console.WriteLine($"names에 요소 있음? {names.HasItems()}");

Console.WriteLine("\n이름 목록:");
names.ForEach(name => Console.WriteLine($"  - {name}"));

public static class CollectionExtensions
{
    public static bool IsEmpty<T>(this ICollection<T> collection)
    {
        return collection.Count == 0;
    }

    public static bool HasItems<T>(this ICollection<T> collection)
    {
        return collection.Count > 0;
    }


    public static void ForEach<T>(this IList<T> list, Action<T> action)
    {
        foreach (var item in list)
        {
            action(item);
        }
    }
}