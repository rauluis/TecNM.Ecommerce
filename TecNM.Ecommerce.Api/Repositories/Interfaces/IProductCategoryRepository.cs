using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories.Interfaces;

public interface IProductCategoryRepository
{
    //metodo para guardar categorias

    Task<ProductCategory> SaveAsync(ProductCategory category);

    //Metodo para actualizar las categorias de Productos

    Task<ProductCategory> UpdateAsync(ProductCategory category);
    //Metodo para retornar una Lista de categorias
    Task<List<ProductCategory>> GetAllAsync();

    //Metodo para retornar el id de las categorias que borrara

    Task<bool> DeleteAsync(int id);

    //Metodo para obtener uan categoria por id
    Task<ProductCategory> GetById(int id);

    }