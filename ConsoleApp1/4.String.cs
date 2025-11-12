using System;



class String
    {
    static void Main()
    {
        string name= "vasavireddy";
        Console.WriteLine(name);

        string uCourseName = "\"Csharp\"";
        Console.WriteLine(uCourseName);

        string line = "one.\n two.\n three";
        Console.WriteLine(line);

        string myProjectPath = "D:\\Csharp_Nov\\MyFirstConsoleApp";
        Console.WriteLine(myProjectPath);

        string url = "https://google.com";
        Console.WriteLine(url);

        string myProjectPath1 = @"D:\Csharp_Nov\MyFirstConsoleApp";
        Console.WriteLine(myProjectPath1);

        string sName = "sreenu";
        int salary = 2000000;

        //string interpolaiton technique
        string empDetails = $"emp name : {sName} , emp salary : {salary} ";
        Console.WriteLine(empDetails);



    }

}

