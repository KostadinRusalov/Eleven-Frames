using System;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class PictureManager : IDB<Picture, int>
    {
        public void Create(Picture item)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    dbContext.Pictures.Add(item);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Picture Read(int key)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    return dbContext.Pictures.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Picture> ReadAll()
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    return dbContext.Pictures.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Picture item)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    Picture picFromDB = dbContext.Pictures.Find(item.ID);
                    dbContext.Entry(picFromDB).GetDatabaseValues().SetValues(item);
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
                    Picture picFromDB = dbContext.Pictures.Find(key);
                    dbContext.Pictures.Remove(picFromDB);
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
