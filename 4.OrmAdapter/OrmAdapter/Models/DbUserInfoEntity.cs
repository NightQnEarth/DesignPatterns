using System;
using OrmAdapter.Models.Interfaces;

namespace OrmAdapter.Models
{
    public class DbUserInfoEntity : IDbEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}