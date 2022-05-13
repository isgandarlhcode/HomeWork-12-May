using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 5 , 7 , 9 , 12 , 14 , 20 , 25 ,30 , 31 , 33 , 34,  67, 89, 90 , 96 , 100 , 106 , 110 , 112, 140 ,170 , 232, 456, 768, 900, 2222, 3434, 6565,7878 };
            int searchingValue = 0;
            int minNum = 0;
            int maxNum = numbers.Length - 1;
            string sorgu;
            bool isContinue = true;

            Console.WriteLine("Istediyiniz reqemi daxil edin :");
            searchingValue = int.Parse (Console.ReadLine());

            do
            {
                int mid = (minNum + maxNum) / 2;
                if (searchingValue == numbers[mid])
                {
                    Console.WriteLine("Sizin daxil etdiyiniz reqemin indexi: " + (mid));
                    isContinue = false;
                }
                else if (numbers[mid] != searchingValue)
                {
                    Console.WriteLine("Sizin reqeminiz " + numbers[mid] +
                        "-den Yuxaridirmi, asagidirmi ?");
                    sorgu = Console.ReadLine();
                    if (sorgu == "yuxari")
                    {
                        minNum = mid + 1;
                    }
                    if (sorgu == "asagi")
                    {
                        maxNum = mid - 1;
                    }
                }
                else
                {
                    Console.WriteLine("Duzgun cavab qeyd edin");
                }
            } while (isContinue);
        }
        }
    }
