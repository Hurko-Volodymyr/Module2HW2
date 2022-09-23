namespace Module2HW2
{
    /// <summary>
    /// Main Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Starts the App.
        /// </summary>
        /// <param name="args">console call params.</param>
        private static void Main(string[] args)
        {
            var shop = new Shop();
            shop.ProductsList.Add(new Product { Name = "Мармелад", Price = 10 });
            shop.ProductsList.Add(new Product { Name = "Зефир", Price = 11 });
            shop.ProductsList.Add(new Product { Name = "Карамель", Price = 12 });
            shop.ProductsList.Add(new Product { Name = "Торт", Price = 13 });
            shop.ProductsList.Add(new Product { Name = "Шоколад", Price = 14 });
            shop.ProductsList.Add(new Product { Name = "Бизе", Price = 15 });
            shop.ProductsList.Add(new Product { Name = "Пирожное", Price = 16 });
            shop.ProductsList.Add(new Product { Name = "Штрудель", Price = 17 });
            shop.ProductsList.Add(new Product { Name = "Печенье", Price = 18 });
            shop.ProductsList.Add(new Product { Name = "Кекс", Price = 19 });
            shop.ProductsList.Add(new Product { Name = "Конфеты", Price = 20 });
            shop.ProductsList.Add(new Product { Name = "Круассан", Price = 21 });
            shop.ProductsList.Add(new Product { Name = "Эклер", Price = 22 });
            shop.ProductsList.Add(new Product { Name = "Тесто", Price = 23 });
            shop.ProductsList.Add(new Product { Name = "Пирог", Price = 24 });
            shop.ProductsList.Add(new Product { Name = "Крендель", Price = 25 });
            shop.ProductsList.ForEach(product => Console.WriteLine($"Доступен товар: {product.Name}; Цена: {product.Price} грн."));

            Busket busket = new ();
            Random random = new ();
            Random rnd = random;
            int amount = rnd.Next(1, 10);

            for (int i = 0; i < amount; i++)
            {
                int numbers = rnd.Next(1, 999);
                busket.Add(shop.ProductsList[i], numbers);
            }

            int orderCount = rnd.Next(1, 99999);
            Console.WriteLine($"\n Ваш заказ номер: {orderCount}; Вы выбрали товар: ");

            busket.DoSum();
            busket.DoRead();

            busket.BuyingList.ForEach(product => Console.WriteLine($"{product.BuyingProduct.Name} (Цена за штуку: {product.BuyingProduct.Price} грн.) в количестве: {product.Number}"));
            Console.WriteLine($"К оплате: {busket.Sum} грн.");
        }
    }
}