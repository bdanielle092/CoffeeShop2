using CoffeeShop2.Models;
using System.Collections.Generic;

namespace CoffeeShop2.Repositories
{
    public interface ICoffeeRepository
    {
        void Add(Coffee coffee);
        void Delete(int id);
        Coffee Get(int coffeeId);
        List<Coffee> GetAll();
        void Update(Coffee coffee);
    }
}