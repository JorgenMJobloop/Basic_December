using Basic_December;
/// <summary>
/// This is a basic Id verification class, that check if a person is old enough to enter the establishment.
/// </summary>
public class CheckId
{
    // example one: using required keyword
    public Person PersonToCheck;

    private const int _validAge = 18;

    private bool _canEnter;

    public CheckId(Person person)
    {
        PersonToCheck = person;
    }

    public bool CanEnter()
    {
        if (PersonToCheck.Age >= _validAge)
        {
            _canEnter = true;
            VerifiedMessage();
            return _canEnter;
        }
        else
        {
            return _canEnter;
        }
    }

    // helper method
    private void VerifiedMessage()
    {
        Console.WriteLine($"{PersonToCheck.Name} is old enough to enter the establishment.");
    }
}