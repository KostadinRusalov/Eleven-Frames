using System;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class PicDescribtionManager : IDB<PicDescription, int>
    {
        public void Create(PicDescription item)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    dbContext.PicDescriptions.Add(item);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PicDescription Read(int key)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    return dbContext.PicDescriptions.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<PicDescription> ReadAll()
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    return dbContext.PicDescriptions.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(PicDescription item)
        {
            try
            {
                using (ELVNFRMSDBContext dbContext = new ELVNFRMSDBContext())
                {
                    PicDescription picDescrFromDB = dbContext.PicDescriptions.Find(item.ID);
                    dbContext.Entry(picDescrFromDB).GetDatabaseValues().SetValues(item);
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
                    PicDescription picDescrFromDB = dbContext.PicDescriptions.Find(key);
                    dbContext.PicDescriptions.Remove(picDescrFromDB);
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
