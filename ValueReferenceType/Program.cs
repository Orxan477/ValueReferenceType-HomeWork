using System;

namespace ValueReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sade bolenlerin sayini tap
            //while (true)
            //{
            //    try
            //    {
            //        int count = 0;
            //        bool test;
            //        Console.Write("Ededi daxil edin=");
            //        string input = Console.ReadLine();
            //        int n = int.Parse(input); ;
            //        for (int i = 2; i <= n; i++)
            //        {
            //            if (n % i == 0)
            //            {
            //                for (int j = 2; j <= i; j++)
            //                {
            //                    test = true;
            //                    while (j < i)
            //                    {
            //                        if (i % j == 0)
            //                        {
            //                            test = false;
            //                            break;
            //                        }
            //                        j++;
            //                    }
            //                    if (test == true)
            //                    {
            //                        count++;
            //                        Console.Write($"{count}.eded=" + i + "   ");
            //                    }
            //                    break;
            //                }
            //            }
            //        }
            //        Console.WriteLine("Count=" + count);
            //        break;
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Duzgun input verin");
            //        Console.WriteLine("------------------");
            //    }
            //}
            #endregion

            #region İki integer array-i arasında dəyəri en böyük olan elementi tapın.          
            //Console.Write("arr massivinin uzunlugunu daxil edin=");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.Write("arr1 massivinin uzunlugunu daxil edin=");
            //int m = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = new int[m];
            ////`int max1 = arr1[0];
            //for (int j = 0; j < arr1.Length; j++)
            //{
            //    arr1[j] = Convert.ToInt32(Console.ReadLine());
            //    if (arr1[j] > max)
            //    {
            //        max = arr1[j];
            //    }
            //}

            //Console.WriteLine("--------");
            //Console.WriteLine("En boyuk eded="+max);
            #endregion

            #region Verilmiş n ədədinin son rəqəmini onun əvvəlinə gətirərək yeni bir ədəd düzəldin 
            int n, a, b, c;
            n = Convert.ToInt32(Console.ReadLine());

            //n = 6;
            a = n % 10;
            b = n / 10;

            Console.WriteLine("Daxil edilen eded=" + n + "\n\nSonuncu reqemi evvele getirenden sonra alinan eded=" + a + b);
            #endregion
        }
    }
}

