using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.ClientService
{
    // интерфейс DAO для работы с клиентом
    public interface IDaoProduct
    {
        // базовый CRUD
        Task<List<Product>> GetAllAsync();
        Task<Product> AddAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> DeleteAsync(int id);
        Task<Product> GetAsync(int id);
    }
}
