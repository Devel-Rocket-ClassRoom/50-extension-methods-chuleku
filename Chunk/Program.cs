using System;
using System.Collections.Generic;
using System.Linq;


Console.WriteLine("=== 컬렉션 청킹 테스트 ===");
int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine();
Console.WriteLine("[숫자를 3개씩 그룹화]");
foreach(var i in number.Chunk(3))
{
    Console.WriteLine($"[{string.Join(", ", i)}]");
}
Console.WriteLine();
Console.WriteLine("[학생들을 2명씩 팀 구성]");
string[] person = { "김철수", "이영희", "박민수", "최지연", "정우진" };
int count = 1;
foreach(var p in person.Chunk(2))
{
    Console.WriteLine($"팀 {count++}: {string.Join(", ", p)}");
}
Console.WriteLine();
Console.WriteLine("[페이지별로 5개씩 나누기]");
int[] pages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
int count1 = 1;
foreach(var num in pages.Chunk(5))
{
    Console.WriteLine($"페이지 {count1++}: {string.Join(", ",num)}");
}