using System;

// 1. 체이닝 vs 중첩 호출
/*string input = "  hello world  ";

string result1 = StringExtensions.Replace(
    StringExtensions.Upper(
        StringExtensions.Trim(input)), ' ', '_');

string result2 = input
    .Trim()
    .Upper()
    .Replace(' ', '_');

Console.WriteLine($"결과1: {result1}");
Console.WriteLine($"결과2: {result2}");

public static class StringExtensions
{
    public static string Upper(this string text)
    {
        return text.ToUpper();
    }

    public static string Trim(this string text)
    {
        return text.Trim();
    }

    public static string Replace(this string text, char oldChar, char newChar)
    {
        return text.Replace(oldChar, newChar);
    }
}*/
// 2. 접근 할 수 없는 멤버
/*SecretBox box = new SecretBox();
box.ShowData();
public class SecretBox
{
    private string _secret = "비밀";
    public string PublicData = "공개";
}

public static class SecretBoxExtensions
{
    public static void ShowData(this SecretBox box)
    {
        Console.WriteLine($"공개 데이터: {box.PublicData}");

    }
}*/

// 3. 인스턴스 메서드 우선
Greeter g = new Greeter();
g.SayHello();    
g.SayGoodbye();  
GreeterExtensions.SayHello(g);

public class Greeter
{
    public void SayHello()
    {
        Console.WriteLine("인스턴스 메서드: 안녕하세요!");
    }
}

public static class GreeterExtensions
{
    public static void SayHello(this Greeter greeter)
    {
        Console.WriteLine("확장 메서드: 반갑습니다!");
    }

    public static void SayGoodbye(this Greeter greeter)
    {
        Console.WriteLine("확장 메서드: 안녕히 가세요!");
    }
}