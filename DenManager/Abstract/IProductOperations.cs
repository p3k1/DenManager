using DenManager.DAL;

namespace DenManager.Abstract
{
    public interface IProductOperations
    {
        void Add(Product toAdd, uint quantity);

        void Sell(Product selledProduct, uint quantity);
    }
}