using System.Collections;
using System.Collections.Generic;
using System.Linq;

List<int> ano = new List<int> { 1,2,3,4,5,6,7,8,9,10,120};
List<string> ne = new List<string> { "Kelbasa", "Pop", "Ivan", "Petr","Negr12Ivan" };

Console.WriteLine(ano[10].AsHex());
//foreach (var x in ) Console.WriteLine(x);


public static class ListExtensions
    {
        public static bool IsCountEven<T>(this List<T> list)
        {
            return list.Count % 2 == 0;
        }

        public static List<T> Even<T>(this List<T> list)
        {
            var result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        public static List<T> Selection<T>(this List<T> list, int start, int end)
        {
            return list.GetRange(start, end - start + 1);
        }

        public static T Random<T>(this List<T> list)
        {
            var random = new Random();
            var index = random.Next(list.Count);
            return list[index];
        }
        public static List<string> ShorterThen(this List<string> list, int maxLength)
        {
            return list.Where(s => s.Length < maxLength).ToList();
        }

        public static List<string> Contains(this List<string> list, string contain)
        {
            return list.Where(s => s.Contains(contain)).ToList();
        }

        public static List<string> LengthBetween(this List<string> list, int minLength, int maxLength)
        {
            return list.Where(s => s.Length >= minLength && s.Length <= maxLength).ToList();
        }

        public static List<string> ContainsUpperLetter(this List<string> list)
        {
            return list.Where(s => s.Any(c => char.IsUpper(c))).ToList();
        }

        public static List<string> Upper(this List<string> list)
        {
            return list.Select(s => s.ToUpper()).ToList();
        }
        public static List<string> SuitableAsPassword(this List<string> list)
        {
            return list.Where(s => s.Any(c => char.IsUpper(c)) && s.Any(c => char.IsLower(c)) && s.Any(c => char.IsDigit(c)) && s.Length >= 8 && s.Length <= 16).ToList();
        }
        public static List<int> Divisible(this List<int> list, int divisor)
        {
            return list.Where(i => i % divisor == 0).ToList();
        }
        public static List<string> Hexadecimal(this List<int> list)
        {
            return list.Select(i => i.ToString("X")).ToList();
        }

        public static List<int> Condition(this List<int> list, Func<int, bool> condition)
        {
            return list.Where(condition).ToList();
        }

        public static void Process(this List<int> list, Func<int, int> process)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = process(list[i]);
            }
        }
        public static string AsHex(this int num)
        {
            return num.ToString("X");
        }
}

