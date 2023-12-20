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
                    Console.WriteLine("Добавлено в заказ");
                }
                else
                {
                    Console.WriteLine("Заказ не изменен");
                }
            }
        }

        public double FinalPrice
        {
            get
            {
                return _finalPrice;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Некорректная итоговая стоимость");
                }
                else
                {
                    _finalPrice = value;
                }
            }
        }

        public Order()
        {
            
        }
        public Order(bool isaddtoorder,double cost) 
        {
            _isAddToOrder = isaddtoorder;
            _finalPrice = cost;
        }

        public void AddToOrder(bool isadd,double cost)
        {
            if (isadd)
            {
                FinalPrice += cost;
                Console.WriteLine($"Финальная стоимость: {FinalPrice}");
            }
        }
    }
}

