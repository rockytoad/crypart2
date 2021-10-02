class Person
{
    protected string ID;
    protected string Password;
    protected string Type;
    protected string ALLIDcard;
    public Person(string ID, string Password, string Type,string AllIDcard)
    {
        this.ID = ID;
        this.Password = Password;
        this.Type = Type;
        this.ALLIDcard = ALLIDcard;
    }

    public string GetName()
    {
        return this.ID;
    }

}