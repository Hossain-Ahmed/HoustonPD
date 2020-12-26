using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HoustonPD.Models;

namespace HoustonPD.Repositories
{
    public class UserRepository
    {
        private readonly ProjectDbContext _db;

        public UserRepository()
        {
            _db = new ProjectDbContext();
        }

       
        public bool IsUserValid(User user)
        {
            var isExist = _db.Users.Any(x => x.Name.Equals(user.Name)
            && x.Password.Equals(user.Password));

            return isExist;
        }

        public bool SaveUser(User user)
        {
            _db.Users.Add(user);
            var isInserted = _db.SaveChanges();

            return isInserted > 0;
        }
     
    }
}