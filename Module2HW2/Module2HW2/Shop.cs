using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    /// <summary>
    /// Contains Shop.
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shop"/> class.
        /// Main Program.
        /// </summary>
        public Shop() => this.ProductsList = new List<Product>();

        /// <summary>
        /// Gets or sets main Program.
        /// </summary>
        public List<Product> ProductsList { get; set; }
    }
}
