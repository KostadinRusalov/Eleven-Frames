using System;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class ReviewManager : IDB<Review, int>
    {
        public void Create(Review item)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    dbContext.Reviews.Add(item);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Review Read(int key)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    return dbContext.Reviews.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Review> ReadAll()
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    return dbContext.Reviews.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Review item)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    Review reviewFromDB = dbContext.Reviews.Find(item.ID);
                    dbContext.Entry(reviewFromDB).GetDatabaseValues().SetValues(item);
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
                    Review reviewFromDB = dbContext.Reviews.Find(key);
                    dbContext.Reviews.Remove(reviewFromDB);
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