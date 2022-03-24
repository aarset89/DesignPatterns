namespace DesignPatterns.Exercises.Proxy
{
    public interface IDbContext
    {
        Product GetProduct(int id);
        void MarkAsChanged(Product product);
        void SaveChanges();
    }
}