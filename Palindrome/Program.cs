using System;
using System.Linq;


Console.WriteLine("=== 회문 판별 테스트 ===");
Console.WriteLine($"\"토마토\" -> {Palindrome.IsPalidrome("토마토")}");
Console.WriteLine($"\"기러기\" -> {Palindrome.IsPalidrome("기러기")}");
Console.WriteLine($"\"level\" -> {Palindrome.IsPalidrome("level")}");
Console.WriteLine($"\"Level\" -> {Palindrome.IsPalidrome("Level")}");
Console.WriteLine($"\"A man, a plan, a canal Panama\" -> {Palindrome.IsPalidrome("A man, a plan, a canal: Panama")}");
Console.WriteLine($"\"race a car\" -> {Palindrome.IsPalidrome("race a car")}");
Console.WriteLine($"\"hello\" -> {Palindrome.IsPalidrome("hello")}");
Console.WriteLine($"\"\" -> {Palindrome.IsPalidrome("")}");
