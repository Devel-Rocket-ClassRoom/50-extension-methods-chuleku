using System;
using System.Linq;

Palindrome palindrome = new Palindrome();
Console.WriteLine("=== 회문 판별 테스트 ===");
Console.WriteLine($"\"토마토\" -> {palindrome.IsPalidrome("토마토")}");
Console.WriteLine($"\"기러기\" -> {palindrome.IsPalidrome("기러기")}");
Console.WriteLine($"\"level\" -> {palindrome.IsPalidrome("level")}");
Console.WriteLine($"\"Level\" -> {palindrome.IsPalidrome("Level")}");
Console.WriteLine($"\"A man, a plan, a canal Panama\" -> {palindrome.IsPalidrome("A man, a plan, a canal: Panama")}");
Console.WriteLine($"\"race a car\" -> {palindrome.IsPalidrome("race a car")}");
Console.WriteLine($"\"hello\" -> {palindrome.IsPalidrome("hello")}");
Console.WriteLine($"\"\" -> {palindrome.IsPalidrome("")}");
