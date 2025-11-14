using System;
 class Condition
    {
    static void Main()
    {
        // operatos
        // if statemnt else if statement  else statement 

        bool result = (10 < 20);

        string bankName = "SBI";

        if (bankName == "HDFC")
        {
            Console.WriteLine("MY Password is MadanHDFC!1234");
        }
        else if (bankName == "Axis")
        {
            Console.WriteLine("MY Password is MadanAxi!1234");
        }
        else if (bankName == "SBI")
        {
            Console.WriteLine("MY Password is MadanSBI!1234");
        }
        else
        {
            Console.WriteLine("You do't have permission to see the password");
        }


    }
}
