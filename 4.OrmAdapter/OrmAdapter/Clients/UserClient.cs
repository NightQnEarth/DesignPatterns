using System.Linq;
using OrmAdapter.FirstOrmLibrary;
using OrmAdapter.Models;
using OrmAdapter.SecondOrmLibrary;

namespace OrmAdapter.Clients
{
    public class UserClient
    {
        private IOrmAdapter ormAdapter;

        private IFirstOrm<DbUserEntity> firstOrm1;
        private IFirstOrm<DbUserInfoEntity> firstOrm2;

        private ISecondOrm secondOrm;

        private bool useFirstOrm = true;

        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
            if (useFirstOrm)
            {
                var user = firstOrm1.Read(userId);
                var userInfo = firstOrm2.Read(user.InfoId);
                return (user, userInfo);
            }
            else
            {
                var user = secondOrm.Context.Users.First(i => i.Id == userId);
                var userInfo = secondOrm.Context.UserInfos.First(i => i.Id == user.InfoId);
                return (user, userInfo);
            }

            // you should return DbUserEntity via ormAdapter
            return (null, null);
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            if (useFirstOrm)
            {
                firstOrm1.Add(user);
                firstOrm2.Add(userInfo);
            }
            else
            {
                // add realization by yourself
            }

            // you should create DbUserEntity and DbUserInfoEntity via ormAdapter
        }

        public void Remove(int userId)
        {
            if (useFirstOrm)
            {
                var user = firstOrm1.Read(userId);
                var userInfo = firstOrm2.Read(user.InfoId);

                firstOrm2.Delete(userInfo);
                firstOrm1.Delete(user);
            }
            else
            {
                // add realization by yourself
            }

            // you should remove DbUserEntity and DbUserInfoEntity via ormAdapter
        }

        public UserClient(IOrmAdapter ormAdapter)
        {
            this.ormAdapter = ormAdapter;
        }
    }
}