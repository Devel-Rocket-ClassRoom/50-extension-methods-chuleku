using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== 컬렉션 셔플 테스트 ===");
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("[숫자 리스트 셔플]");
Console.WriteLine($"원본: {string.Join(", ",numbers)}");
Console.WriteLine($"셔플: {string.Join(", ",ShuffleList.Shuffle(numbers))}");
Console.WriteLine();
Console.WriteLine("[카드 덱 셔플]");
string[] cards = { "♠A", "♥K", "♦Q", "♣J" };
Console.WriteLine($"원본: {string.Join(", ",cards)}");
Console.WriteLine($"셔플: {string.Join(", ", ShuffleList.Shuffle(cards))}");
Console.WriteLine();
string[] person = { "김철수", "이영희", "박민수", "최지연", "정우진" };
Console.WriteLine("[학생 순서 무작위 배치]");
Console.WriteLine($"원본: {string.Join(", ",person)}");
Console.WriteLine($"셔플: {string.Join(", ", ShuffleList.Shuffle(person))}");
Console.WriteLine();
