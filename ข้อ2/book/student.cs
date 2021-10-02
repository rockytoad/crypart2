class ALLperson : Person
{
    private string studentID;

    public ALLperson(string ID, string Password, string Type, string AllIDcard)
    : base(ID, Password, Type,AllIDcard)
    {
        this.studentID = studentID;
    }

}