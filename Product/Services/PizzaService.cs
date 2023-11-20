using Product.Models;

namespace Product.Services
{
    public class PizzaService
    {
        private readonly static IEnumerable<Pizza> _pizzas = new
            List<Pizza>()
        {
            new Pizza
            {
                Name = "Pizza 1",
                Image = "p2.png",
                Price = 5.1
            },
            new Pizza
            {
                Name = "Pizza 2",
                Image = "p3.png",
                Price = 2.5
            },
            new Pizza
            {
                Name = "Pizza 3",
                Image = "p4.png",
                Price = 9.5
            },
            new Pizza
            {
                Name = "Pizza 4",
                Image = "p5.png",
                Price = 1.45
            }
        };
        public IEnumerable<Pizza> GetallPizzas() => _pizzas;
        public IEnumerable<Pizza> GetPopularPizzas(int count = 6) => _pizzas.OrderBy(p=> Guid.NewGuid())
            .Take(count);

        public IEnumerable<Pizza> SearchPizzas(string searchTerm) =>
            string.IsNullOrWhiteSpace(searchTerm)
            ? _pizzas
            : _pizzas.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        


        
    }
}
      

        



    

    


