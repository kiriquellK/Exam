namespace Exam
{
    internal class Order
    {
        private bool _isAddToOrder;
        private double _finalPrice;

        public bool IsAddToOrder
        {
            get
            {
                return _isAddToOrder;
            }
            set
            {
                if (!value)
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

