namespace Library;

public class MaxAgeVisitor: IVisitor
{
    private int _maxAge = 0;

    public int MaxAge
    {
        get
        {
            return this._maxAge;
        }
    }

    public void Visit(Node node)
    {
        if (_maxAge < node.Number)
        {this._maxAge = node.Number;}
    }
    
    public void Visit(Person person)
    {
        if (_maxAge < person.Age)
        {this._maxAge = person.Age;}
    }
}
