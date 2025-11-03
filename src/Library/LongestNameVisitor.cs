namespace Library
{
    public class LongestNameVisitor : IVisitor
    {
        private Person _personWithLongestName;

        public Person PersonWithLongestName
        {
            get
            {
                return this._personWithLongestName;
            }
        }

        public string LongestName
        {
            get
            {
                if (this._personWithLongestName != null)
                {
                    return this._personWithLongestName.Name;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Visit(Node node)
        {
        }

        public void Visit(Person person)
        {
            if (this._personWithLongestName == null)
            {
                this._personWithLongestName = person;
                return;
            }

            if (person.Name.Length > this._personWithLongestName.Name.Length)
            {
                this._personWithLongestName = person;
            }
        }
    }
}