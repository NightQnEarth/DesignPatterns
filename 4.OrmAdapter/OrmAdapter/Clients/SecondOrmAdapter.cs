using System.Linq;
using OrmAdapter.Models;
using OrmAdapter.SecondOrmLibrary;

namespace OrmAdapter.Clients
{
    public class SecondOrmAdapter : IOrmAdapter
    {
        private readonly ISecondOrm secondOrm;

        public SecondOrmAdapter(ISecondOrm secondOrm) => this.secondOrm = secondOrm;

        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
            var user = secondOrm.Context.Users.First(i => i.Id == userId);
            var userInfo = secondOrm.Context.UserInfos.First(i => i.Id == user.InfoId);
            return (user, userInfo);
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            secondOrm.Context.Users.Add(user);
            secondOrm.Context.UserInfos.Add(userInfo);
        }

        public void Remove(int userId)
        {
            secondOrm.Context.Users.RemoveWhere(user => user.Id == userId);
            secondOrm.Context.UserInfos.RemoveWhere(userInfo => userInfo.Id == userId);
        }
    }
}