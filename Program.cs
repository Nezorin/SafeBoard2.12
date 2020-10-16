using System;
//https://github.com/Nezorin/SafeBoard2.12 
namespace SafeBoard2._12
{
    class Program
    {
        public enum DataType
        {
            None = 0,
            First = 1,
            Second = 2,
            Third = 3,
            Fourth = 4
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',');
            string invalid = String.Empty;
            int[] counter = new int[] { 0, 0, 0, 0, 0 };
            foreach (var item in input)
            {
                DataType data;
                if (Enum.TryParse(item, out data))
                {
                    switch (data)
                    {
                        case DataType.None:
                            counter[0]++;
                            break;
                        case DataType.First:
                            counter[1]++;
                            break;
                        case DataType.Second:
                            counter[2]++;
                            break;
                        case DataType.Third:
                            counter[3]++;
                            break;
                        case DataType.Fourth:
                            counter[4]++;
                            break;
                    }
                }
                else
                {
                    invalid += item + ",";
                }
                
            }
            Console.WriteLine("Input data types:" + "\n" +
                $"None(0)-{counter[0]}" + "\n" +
                $"First(1)-{counter[1]}" + "\n" +
                $"Second(2)-{counter[2]}" + "\n" +
                $"Third(3)-{counter[3]}" + "\n" +
                $"Fourth(4)-{counter[4]}" + "\n" +
                "Errors:\n" +
                "Not valid input strings: " + invalid.Remove(invalid.LastIndexOf(','), 1)
                );
        }
    }
}
