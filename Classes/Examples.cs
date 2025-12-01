public class Examples
{
    // example two: using nullable checks
    public string? TextField; // can be null
    public int IntegerField; // will default to the integer zero (0), so it cannot be null.

    public string ReturnEmptyString()
    {
        return "";
    }

    public bool TexFieldShouldReturnNullWhenUnassigned()
    {
        if (TextField == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetTextFieldValue()
    {
        return TextField!;
    }

    public bool IntegerFieldShouldBeZeroWhenNotAssigned()
    {
        if (IntegerField == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}