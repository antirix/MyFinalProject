using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;


namespace DataAccess.Concreate.EntitiyFramework
{
    public class EfOrderDal : EfEntityRepositoryBase <Order, NorthwindContext>, IOrderDal
    {
    }
}
