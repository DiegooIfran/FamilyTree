namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Person
{
    private int age;
    private string name;
    private List<Person> children = new List<Person>();

    public int Age {
        get
        {
            return this.age;
        }
    }
    public string Name {
        get
        {
            return this.name;
        }
    }

    public ReadOnlyCollection<Node> Children {
        get
        {
            return this.children.AsReadOnly();
        }
    }

    public Person(int age, string name)
    {
        this.age = age;
        this.name = name;
    }

    public void AddChildren(Node n)
    {
        this.children.Add(n);
    }
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        foreach (var item in this.children)
        {
            item.Accept(visitor);
        }
    }
}