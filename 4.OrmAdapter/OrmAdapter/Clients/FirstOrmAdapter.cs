using OrmAdapter.FirstOrmLibrary;
using OrmAdapter.Models;

namespace OrmAdapter.Clients
{
    public class FirstOrmAdapter : IOrmAdapter
    {
        private readonly IFirstOrm<DbUserEntity> firstOrmWithDbUserEntity;
        private readonly IFirstOrm<DbUserInfoEntity> firstOrmWithDbUserInfoEntity;

        public FirstOrmAdapter(IFirstOrm<DbUserEntity> firstOrmWithDbUserEntity,
                               IFirstOrm<DbUserInfoEntity> firstOrmWithDbUserInfoEntity)
        {
            this.firstOrmWithDbUserEntity = firstOrmWithDbUserEntity;
            this.firstOrmWithDbUserInfoEntity = firstOrmWithDbUserInfoEntity;
        }

        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
            var user = firstOrmWithDbUserEntity.Read(userId);
            var userInfo = firstOrmWithDbUserInfoEntity.Read(user.InfoId);
            return (user, userInfo);
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            firstOrmWithDbUserEntity.Add(user);
            firstOrmWithDbUserInfoEntity.Add(userInfo);
        }

        public void Remove(int userId)
        {
            var user = firstOrmWithDbUserEntity.Read(userId);
            var userInfo = firstOrmWithDbUserInfoEntity.Read(user.InfoId);

            firstOrmWithDbUserInfoEntity.Delete(userInfo);
            firstOrmWithDbUserEntity.Delete(user);
        }
    }
}