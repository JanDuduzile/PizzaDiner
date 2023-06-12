using PizzaDiner.Data;
using PizzaDiner.Models;

namespace PizzaDiner.Services
{
    public class PizzaService
    {
        private readonly PizzaDinerContext _context = default!;

        public PizzaService(PizzaDinerContext context)
        {
            _context = context;
        }

        public IList<Pizza> GetPizzas()
        {
            if (_context.Pizza != null)
            {
                return _context.Pizza.ToList();
            }
            return new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            if (_context.Pizza != null)
            {
                _context.Pizza.Add(pizza);
                _context.SaveChanges();
            }
        }

        public void DeletePizza(int id)
        {
            if (_context.Pizza != null)
            {
                var pizza = _context.Pizza.Find(id);
                if (pizza != null)
                {
                    _context.Pizza.Remove(pizza);
                    _context.SaveChanges();
                }
            }
        }
    }
}