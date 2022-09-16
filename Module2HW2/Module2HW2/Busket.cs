namespace Module2HW2
{
    /// <summary>
    /// Contains Busket.
    /// </summary>
    public class Busket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Busket"/> class.
        /// Starts the App.
        /// </summary>
        public Busket()
        {
            this.BuyingList = new List<Buy>();
        }

        /// <summary>
        /// Gets or sets contains Buyinglist.
        /// </summary>
        public List<Buy> BuyingList { get; set; }

        /// <summary>
        /// Gets or sets starts the App.
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// Starts the App.
        /// </summary>
        /// param name = "boughtProduct"
        public void Add(Product boughtProduct, int numberOfProduct)
        {
            if (boughtProduct is null)
            {
                throw new ArgumentNullException(nameof(boughtProduct));
            }

            this.BuyingList.Add(new Buy { BuyingProduct = boughtProduct, Number = numberOfProduct });
        }

        /// <summary>
        /// Starts the App.
        /// </summary>
        public void DoSum()
        {
            this.BuyingList.ForEach(action: buy => this.Sum += buy.BuyingProduct.Price * buy.Number);
        }

        /// <summary>
        /// Starts the App.
        /// </summary>
        public void DoRead()
        {
        this.BuyingList.ForEach(product => Console.WriteLine(value: $"{product.BuyingProduct.Name} (Цена за штуку: {product.BuyingProduct.Price} грн.) в количестве: {product.Number}"));
        }
    }
}
