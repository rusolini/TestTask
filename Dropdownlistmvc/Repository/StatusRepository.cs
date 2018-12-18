using System.Collections.Generic;
using WhatWeEat.Data;
using WhatWeEat.Service;

namespace WhatWeEat.Repository
{
    public class StatusRepository : IUserStatus
    {
        private readonly EfDbContext _context = new EfDbContext();
        public IEnumerable<UserStatus> GetUserStatus => _context.UserStatus;

        public void AddUserStatus(UserStatus userStatus)
        {
            _context.UserStatus.Add(userStatus);
            _context.SaveChanges();
        }
    }
}