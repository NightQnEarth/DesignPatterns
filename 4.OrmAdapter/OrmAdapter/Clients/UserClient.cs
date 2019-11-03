using OrmAdapter.FirstOrmLibrary;
using OrmAdapter.Models;
using OrmAdapter.SecondOrmLibrary;

namespace OrmAdapter.Clients
{
    public class UserClient
    {
        private readonly FirstOrmAdapter firstOrmAdapter;
        private readonly SecondOrmAdapter secondOrmAdapter;
        private readonly bool useFirstOrm = true;

        private IOrmAdapter GetUsedAdapter => useFirstOrm ? (IOrmAdapter)firstOrmAdapter : secondOrmAdapter;

        public UserClient(IFirstOrm<DbUserEntity> firstOrmWithUsers,
                          IFirstOrm<DbUserInfoEntity> firstOrmWithUsersInfo,
                          ISecondOrm secondOrm)
        {
            firstOrmAdapter = new FirstOrmAdapter(firstOrmWithUsers, firstOrmWithUsersInfo);
            secondOrmAdapter = new SecondOrmAdapter(secondOrm);
        }

        public (DbUserEntity, DbUserInfoEntity) Get(int userId) => GetUsedAdapter.Get(userId);

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo) => GetUsedAdapter.Add(user, userInfo);

        public void Remove(int userId) => GetUsedAdapter.Remove(userId);
    }
}