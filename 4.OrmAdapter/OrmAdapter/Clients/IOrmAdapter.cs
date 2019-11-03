using OrmAdapter.Models;

namespace OrmAdapter.Clients
{
    public interface IOrmAdapter
    {
        (DbUserEntity, DbUserInfoEntity) Get(int userId);
        void Add(DbUserEntity user, DbUserInfoEntity userInfo);
        void Remove(int userId);
    }
}