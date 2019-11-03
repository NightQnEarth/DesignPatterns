using OrmAdapter.Models.Interfaces;

namespace OrmAdapter.FirstOrmLibrary
{
    public interface IFirstOrm<TDbEntity> where TDbEntity : IDbEntity
    {
        void Add(TDbEntity entity);
        TDbEntity Read(int id);
        void Delete(TDbEntity entity);
    }
}