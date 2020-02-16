namespace PNY.ASPNET20.Common
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Country() { }
        public Country(string name)
        {
            Name = name;
        }

        public Country (string name, int id):this(name)
        {
            ID = id;
        }
    }
}