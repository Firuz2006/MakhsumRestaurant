using MakhsumRestaurantt.Abstractions;
using MakhsumRestaurantt.Menu.Categories.SalatsModels;

namespace MakhsumRestaurantt.Menu.Categories;

public class Salats:MenuItem, ICategories 
{
    private readonly Dictionary<Guid, ISalats> _listSalatsMap=new();

    public void Add<T>(T salat) where T: MenuItem, ISalats
    {
        _listSalatsMap.Add(salat.Id,salat);
    }
}