public class Person
{
    private string name;
    private string email;
    private string phoneNo;

    public Person(string name, string email, string phoneNo)
    {
        this.name = name;
        this.email = email;
        this.phoneNo = phoneNo;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string PhoneNo
    {
        get { return phoneNo; }
        set { phoneNo = value; }
    }
}