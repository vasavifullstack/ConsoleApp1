using System;
class Array
{
    static void Main()
    {
        int[] number = new int[5];  //numbersGroup accepts 2 values;
        number[0] = 678;
        number[1] = 276;
        number[2] = 576;
        number[3] = 876;
        number[4] = 276;


        Console.WriteLine(number[0]);  // 678
        Console.WriteLine(number[1]);  // 276
        Console.WriteLine(number[2]);
        Console.WriteLine(number[3]);
        Console.WriteLine(number[4]);

        //numbersGroup[2] = 32;   //No Complie time error.
        //Console.WriteLine(numbersGroup[2]);

        //string length , array length

        int[] numbersGroup1 = new int[] { 101, 201, 301, 401 };
        Console.WriteLine(numbersGroup1[numbersGroup1.Length - 1]);  // improvement 

        numbersGroup1[2] = 300;
        Console.WriteLine(numbersGroup1[2]);

        ///student1 : hey print each and every value..

        //Console.WriteLine(numbersGroup1[0]);   // 101
        //Console.WriteLine(numbersGroup1[1]);   // 201
        //Console.WriteLine(numbersGroup1[2]);   // 300
        //Console.WriteLine(numbersGroup1[3]);   // 401


        //foreach (int number in numbersGroup1) {  
        //    Console.WriteLine(number);
        //}


        foreach (var numbers in numbersGroup1)
        {
            Console.WriteLine(numbers);
        }






    }

}