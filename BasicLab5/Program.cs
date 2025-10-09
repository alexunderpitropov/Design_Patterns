using System;

class Program
{
    static void Main()
    {
        Prices prices = new Prices
        {
            drink = 10,
            first = 20,
            second = 30
        };

        // Клиент 1
        {
            Choices choices = new Choices
            {
                drink = 100,
                first = 0,
                second = 250
            };

            int total = CustomerTotal(prices, choices);
            Console.WriteLine("Стоимость заказа клиента 1: " + total + " лей.");
        }

        // Клиент 2
        {
            Choices choices = new Choices
            {
                drink = 0,
                first = 300,
                second = 0
            };

            int total = CustomerTotal(prices, choices);
            Console.WriteLine("Стоимость заказа клиента 2: " + total + " лей.");
        }
    }

    struct Prices
    {
        public int drink;
        public int first;
        public int second;
    }

    struct Choices
    {
        public int drink;
        public int first;
        public int second;
    }

    static int CustomerTotal(Prices prices, Choices choices)
    {
        int drinkCost = (choices.drink / 100) * prices.drink;
        int firstCost = (choices.first / 100) * prices.first;
        int secondCost = (choices.second / 100) * prices.second;
        return drinkCost + firstCost + secondCost;
    }
}
