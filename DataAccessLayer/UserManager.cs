using System;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class UserManager : IDB<User, int>
    {
        public void Create(User item)
        {
            try
            {
                using(ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    dbContext.Users.Add(item);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User Read(int key)
        {
            try
            {
                using(ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    return dbContext.Users.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<User> ReadAll()
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    return dbContext.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(User item)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    User userFromDB = dbContext.Users.Find(item.ID);
                    dbContext.Entry(userFromDB).GetDatabaseValues().SetValues(item);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    User userFromDB = dbContext.Users.Find(key);
                    dbContext.Users.Remove(userFromDB);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
