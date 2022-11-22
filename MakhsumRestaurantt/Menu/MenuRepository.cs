
using MakhsumRestaurantt.Abstractions;

namespace MakhsumRestaurantt.Menu;

public sealed class MenuRepository
{
    private readonly Dictionary<Guid, ICategories> _listCategoriesMap=new();

    public void Add<T>(T category) where T: MenuItem, ICategories
    {
        _listCategoriesMap.Add(category.Id,category);
    }
}