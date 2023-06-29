using System;
using BusinessLayer;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class ELVNFRMSDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<PicDescription> PicDescriptions { get; set; }

        public ELVNFRMSDBContext() : base ("ELVNFRMSDB")
        {
        }
    }
}
