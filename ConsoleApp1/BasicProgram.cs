using System;
 class BasicProgram
    {
    static void Main() {
        Console.WriteLine("Hii Vasavi Reddy");
        Console.WriteLine("Welcome to Csharp");

        //numerical datatypes    numbers
        //byte , short , ushort , int , unit, long , ulong , decimal and double

        Byte num = 100;   // 0-255
        Console.WriteLine(num);

        //Range : 32767 to -32768
        short num1 = 1000;
        short num2 = -1000;
        Console.WriteLine(num1);
        Console.WriteLine(num2);


        //range : 0 to 65535
        //Purpose: store small number values
        ushort billAmount = 5000;
        Console.WriteLine(billAmount);

        //int --- -2,147,483,648 to 2,147,483,647
        //default datatype for integers

        int salary = 500000;
        Console.WriteLine(salary);  // integer

        //uint - 0 to 4,294,967,295
        uint population = 3000000000U;

        Console.WriteLine(population);
        Console.WriteLine(7800);  //int
        Console.WriteLine(5676U); //Uint

        //Long
        // range : -9223372036854775808 to  9223372036854775807
        long worldpopulation = 7800000000L;
        Console.WriteLine(worldpopulation);

        //ulong
        //range 0 - 10,00,00,00,00,00,000
        ulong indiaGDP = 200000000000UL;
        Console.WriteLine(indiaGDP);
        //Floating datatypes

        //0.68 , 1.9, 10.898       10 , 10.0

        //decimal ---> 1.0*10^-28 to 7.9*10^28
        //purpose : money or finanical transactions 
        decimal price = 199.99M;   //decimal
        Console.WriteLine(price);


        //float -- floating datatype
        //range - -3.40282347*10^38 to 3.40282347*10^38
        //purpose : scientific calculaitons

        float pi = 3.14f;
        Console.WriteLine(pi);


        //double - floating datatype
        // range +- 5.0*10-324 * +- 1.7*10^388
        //purpose -- Mathematical computations(Stocks)
        double db = 987.898d;
        Console.WriteLine(db);







    }
}
