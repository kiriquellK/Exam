using Exam;

namespace exam
{
    class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order(true,12);
            order.FinalPrice();

        }
    }
}