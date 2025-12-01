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
        int myNumber = 25; // integer, explicit cast, js equavalent: let myNumber = 25;
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

        // Data structures
        string[] shoppingItems = ["milk", "chicken", "beef", "coca-cola", "chocolate"]; // arrays have a fixed size in C#
        Console.WriteLine(shoppingItems.Length); // should either be 5 or 6 (if the Append method works)
        List<string> shoppingList = shoppingItems.ToList(); // we clone our fixed-size array into a new list, so we can push/pop items as we want.
        shoppingList.Add("tomato sauce");
        shoppingList.Remove("milk");

        Console.WriteLine("Items in array:");
        // use a regular for loop for the items in the array
        for (int i = 0; i < shoppingItems.Length; i++)
        {
            Console.WriteLine(shoppingItems[i]);
        }

        // use a foreach loop (more readable) to print the items in the shoppingList List
        foreach (string items in shoppingList)
        {
            Console.WriteLine(items);
        }
        Console.Read(); // pause the execution, and wait for a key-press to continue

        // Classes & objects
        Person person = new Person(); // declaration of a new Person class object
        person.Name = "John Doe";
        person.Age = 35;
        person.Hobbies = ["Skiing", "Programming", "Gaming"];

        Examples examples = new Examples(); // initalize a new examples object from the Examples class
        examples.TextField = "";
        var result = examples.IntegerFieldShouldBeZeroWhenNotAssigned();
        var isNull = examples.TexFieldShouldReturnNullWhenUnassigned();
        Console.WriteLine(result);
        Console.WriteLine(isNull);

        CheckId checkId = new CheckId(person);
        Console.WriteLine($"If the persons age is greater than or equal to 18, they can enter, and this should return true: {checkId.CanEnter()}");
    }
}