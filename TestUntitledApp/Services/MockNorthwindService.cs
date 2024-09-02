using UntitledApp.Models.Northwind;

namespace UntitledApp.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<CategoriesType>> GetCategories()
        {
            return Task.FromResult<List<CategoriesType>>(new());
        }
    }
}
