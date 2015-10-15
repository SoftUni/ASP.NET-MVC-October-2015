using LaptopStore.Data.Repositories;
using LaptopStore.Models;

namespace LaptopStore.Data.UnitOfWork
{
    public interface ILaptopStoreData
    {
        IRepository<User> Users { get; set; }

        IRepository<Laptop> Laptops { get; set; }

        void SaveChanges();
    }
}
