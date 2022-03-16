using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;


namespace DataAccess.Concreate.EntitiyFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        
    }
}
