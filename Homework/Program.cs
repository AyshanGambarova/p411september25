using System;

namespace Homework
{
    class Program
    {


        #region Besinci method
        //static void PrimeNumber(int number)
        //{

        //    for (int i = 2; i < number; i++)
        //    {
        //        if (number % i != 0)
        //        {
        //            Console.Write("Sade ededdir");
        //            break;
        //        }
        //    }


        //}

        #endregion

        #region Altinci method
        //static int FactorialOfNumber(int number)
        //{
        //    int factorial = 1;

        //    for (int i = 1; i <= number; i++)
        //    {
        //        factorial *= i;
        //    }

        //    return factorial;
        //}

        #endregion



        static void Main(string[] args)
        {
            #region 1

            //Console.WriteLine("Bali daxil edin: ");

            //while (true)
            //{

            //    try
            //    {
            //        int mark = Convert.ToInt32(Console.ReadLine());
            //        if (mark <= 100 && mark > 90)
            //        {
            //            Console.WriteLine("A");
            //        }
            //        else if (mark <= 90 && mark > 80)
            //        {
            //            Console.WriteLine("B");
            //        }
            //        else if (mark <= 80 && mark > 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else if (mark <= 70 && mark > 60)
            //        {
            //            Console.WriteLine("D");
            //        }
            //        else if (mark <= 60 && mark > 50)
            //        {
            //            Console.WriteLine("E");
            //        }
            //        else if (mark <= 50)
            //        {
            //            Console.WriteLine("Kesr");

            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Error");
            //    }

            //}

            #endregion

            #region 2


            //1ci usul
            //Console.WriteLine("Ededi daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        Console.WriteLine("Ededin bolenleri: " + i);
            //    }

            //2ci usul
            //Console.WriteLine("Ededi daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int divider =0;


            //Console.WriteLine("Daxil edilmis ededin bolenleri: "); !!!!!!CAUTION

            //while (num >= divider)

            //{
            //    if (num % divider == 0)
            //    {
            //        divider++;

            //    }
            //    Console.WriteLine(divider);
            //}


            #endregion

            #region 3

            //1ci usul
            //int i = 0;
            //Console.Write("Ededi daxil edin: ");
            //long num = Convert.ToInt64(Console.ReadLine());


            //while (num >= 1)
            //{
            //    num /= 10;
            //    i++;
            //}
            //Console.WriteLine(i);

            //2ci usul
            //Console.WriteLine("Eded daxil edin: ");

            //int num = Convert.ToInt32(Console.ReadLine());


            //int mertebe = 0;


            //while (num >= 1)
            //{

            //    num = (num - (num % 10)) / 10;
            //    mertebe++;

            //}


            #endregion

            #region 4
            //Console.Write("Ededi daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;

            //while (num >= 1)
            //{
            //    sum += num % 10;
            //    num = (num - (num % 10)) / 10;

            //}

            //Console.WriteLine("Ededin reqemlerinin cemi: " + sum);
            #endregion

            #region 5

            //Console.Write("Ededi daxil edin: ");
            //int num = Convert.ToInt16(Console.ReadLine());

            //PrimeNumber(num);


            #endregion

            #region 6

            //Console.WriteLine("Ededi daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());



            //Console.WriteLine(FactorialOfNumber(number));

            #endregion

            #region 7
            //1ci usul
            //int[] numbers = { 1063, 84, 269, 47 };
            //int max = numbers[0];
            //int min = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] >= max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine("Arraydaki max. eded: " + max);


            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] <= min)
            //    {
            //        min = numbers[i];
            //    }
            //}

            //Console.WriteLine("Arraydaki min. eded: " + min);


            //2ci usul
            //int[] numbers = { 1063, 84, 269, 47 };
            //int max = numbers[0];

            //foreach (int number in numbers) 
            //{
            //    if (number>=max)
            //    {
            //        max = number;
            //    }
            //}

            //Console.WriteLine("Arraydaki max. eded: " + max);


            //int[] numbers = { 1063, 84, 269, 47 };
            //int min = numbers[0];

            //foreach (int number in numbers)
            //{
            //    if (number <= min)
            //    {
            //        min = number;
            //    }
            //}

            //Console.WriteLine("Arraydaki min. eded: " + min);






            #endregion

            #region 8
            //Console.Write("Ededi daxil edin: ");
            //int season = Convert.ToInt32(Console.ReadLine());

            //if (season <= 4)
            //{
            //    switch (season)
            //    {
            //        case 1:
            //            Console.WriteLine("Spring");
            //            break;
            //        case 2:
            //            Console.WriteLine("Summer");
            //            break;
            //        case 3:
            //            Console.WriteLine("Autumn");
            //            break;
            //        case 4:
            //            Console.WriteLine("Winter");
            //            break;

            //    }
            //}
            //else
            //{
            //    Console.Write("Error");
            //}

            #endregion

            #region 9
            ////1ci usul

            //string[] names = { "Ayshan", "Fidan", "Mehemmed", "Rasul" };

            //string longest = names[0];

            //foreach (string name in names)

            //{
            //    if (name.Length > longest.Length)
            //    {
            //        longest = name;
            //    }
            //}
            //Console.WriteLine("Arraydaki en uzun soz: " + longest);


           

            #endregion




        }

    }
}

