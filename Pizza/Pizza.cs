namespace Pizza
{
    public class Pizza
    {
        public bool Cheese { get; set; }
        public bool Tomatoes { get; set; }
        public bool Olives { get; set; }
        public bool Meat { get; set; }

        public string ShowComposition()
        {
            return 
                $"Your choice:\n" +
                $"Cheese: {(Cheese ? "Yes" : "No")}\n"+
                $"Tomatoes: {(Tomatoes ? "Yes" : "No")}\n" +
                $"Olives: {(Olives ? "Yes" : "No")}\n" +
                $"Meat: {(Meat ? "Yes" : "No")}";
        }
    }
}