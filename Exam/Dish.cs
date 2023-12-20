namespace Exam
{
    internal class Dish
    {
        private string? _name;
        private double _cost;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Некорректная название");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public double Cost
        { 
            get
            {
                return _cost;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Некорректная стоимость");
                }
                else
                {
                    _cost = value;
                }
            }
        }

        public Dish(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
