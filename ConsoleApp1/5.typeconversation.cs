using System;
 class TypeConversation
    {
    static void Main()
    {
        //Type conversations are 2 types

        ////implicit type conv 
        ////numeric type int - byte  -- i do't get any kind of headaches
        ///
        //byte age = 20;  // numeic
        //int largeAge = age;  // i can do that
        //Implicit conversion in C# is the process where the compiler automatically
        //converts one data type to another without requiring explicit syntax by the programmer.

     //happens when there’s no risk of data loss — for example,
        //converting a smaller type to a larger compatible type.

        ////explicit type conv
        //int salary = 10000;  //just assume emp salary
        ////byte smallsalary = salary;
        //u salary1 = salary;
        //Explict   --


        // you are going to give the guidance to the compiler exactly what is the type i.e.

        // explicit type
        int age1 = 25; //explicity you are telling -- compiler 
        string name1 = "Csharp"; //
        double package1 = 67890.90;

        Console.WriteLine(age1);
        Console.WriteLine(name1);
        Console.WriteLine(package1);

        //Explicit type conversation
        double price = 12356.75;
        int amount = (int)price;   //its very imporantve  you have to manually casting that.
        Console.WriteLine(amount);  //12356   //you are loosing    .75(fractional) value...


        long phoneNumber = 7878776668;
        byte byte1 = (byte)phoneNumber;
        Console.WriteLine(byte1);   //again 

        //implict type 
        // let your compiler understand what it the type you have assinged value.
        var age = 25;  //complier is understanding
        var name = "csharp"; //complier understand the string
        Console.WriteLine(age);
        Console.WriteLine(name);
        //Happens automatically without loosing the data.
        // here you do't need any cast
        int number = 100;
        double result = number; // int --> double
        Console.WriteLine(result);   // 100
        // byte - int
        // int - long
        // float - double
        //boxing and unboxing 
        // convert the value type to ref   type   -- Boxing
        // convert the ref   type to value type   -- Unboxing
        //value type -  10 , 20 , 123.78;  actaul type
        //value type stores the actual value
        //ref   type - Object(can store any value)  , string 
        // ref type stores address of the actual 

        //Boxing : Exammple
        int RoomNo = 10;      // here roomno is the value type stores the actual value i.e. 10   
        object obj1 = RoomNo;    // Generally object can stores the ref of the actual data
                                 // Now obj1 take the ref of to the boxed objet(roomno)

        object obj2 = 10;
        int RoomNo2 = (int)obj2;   //unbox

        string str1 = "Csharp";
        string str2 = str1;     //now str2 pointing to same ref of str1


        Console.WriteLine(str1);   //Csharp;
        Console.WriteLine(str2);   //Csharp;

        str2 = ".net";
        Console.WriteLine(str2);   //.net;  //now str2 makes it point to the new string 

   }
}
