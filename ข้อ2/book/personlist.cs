using System;
using System.Collections.Generic;
using System.Text;

class PersonList
{
    private List<Person> personList;

    public PersonList()
    {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person)
    {
        this.personList.Add(person);
    }

    public void FetchPersonsList()
    {
        Console.WriteLine("List Persons");
        Console.WriteLine("---------------------");
        foreach (Person person in this.personList)
        {
            if (person is ALLperson)
            {
                Console.WriteLine("Name: {0} \nType: Student \n", person.GetName());
            }
        }
    }
}
