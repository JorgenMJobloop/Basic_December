namespace Basic_December;

class Program
{
    static void Main(string[] args)
    {
        // variables & datatypes
        // explicit type casting
        string helloWorld = "Hello, World!";
        Console.WriteLine(helloWorld);
        // implicit type casting (hinted types, compiler recognizes the type at runtime)
        // var myNumber = 25; // integer
        int myNumber = 25; // integer, explicit cast
        Console.WriteLine(myNumber * 2.5);
        double myDecimalNumber = 25.5; // double
        Console.WriteLine(myNumber + myDecimalNumber);
        bool shouldBeTrue = true;
        Console.WriteLine(shouldBeTrue);
        char a = 'a';
        char b = 'b';
        Console.WriteLine(a + b);
        /*
        Special data types
        */
        byte myByte = 0x1; // 0 bytes assigned
        Console.WriteLine(myByte);
    }
}