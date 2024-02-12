namespace WebApplication1
{
    public class Person

    {
        public string Name { get; set; } = "";
        public int Age { get; set; } = 0;
        public String Location { get; set; } = "";


        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nLocation: {Location}";
        }

    }

}
