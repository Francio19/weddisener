using UntitledApp.Models.Northwind;

namespace UntitledApp.Northwind
{
    public interface INorthwindService
    {
        Task<List<CategoriesType>> GetCategories();
    }
}
