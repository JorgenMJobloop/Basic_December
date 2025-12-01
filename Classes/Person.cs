namespace Basic_December;
/// <summary>
/// 
/// </summary>
public class Person
{
    // Fields

    /// <summary>
    /// The name of any given person
    /// </summary>
    public string? Name;
    /// <summary>
    /// The age of any given person
    /// </summary>
    public int Age;

    // fields can also be data structures or collections
    public List<string> Hobbies = new List<string>();

    // methods

    public string GetName()
    {
        if (Name == null)
        {
            throw new Exception("Name cannot be null!");
        }
        return Name;
    }

    public int GetAge()
    {
        return Age;
    }

    public void PrintInfo()
    {
        if (Hobbies == null || Hobbies.Count == 0)
        {
            Console.WriteLine($"{Name} has no hobbies listed.");
        }
        string values;
        if (Hobbies!.Count == 1)
        {
            values = Hobbies[0];
        }
        else
        {
            values = string.Join(", ", Hobbies.Take(Hobbies.Count - 1)) + "&" + Hobbies.Last();
        }
        Console.WriteLine($"{Name} is {Age} years old. And they enjoy {values}");
    }
}