using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Data.Entities;
#endregion
namespace ChinookSystem.DAL
{
    // this is an inte rnal class for security reasons
    //access is restriced to within this class library project
    //inherits DbContext for Entity Framewoek, which requires
    // System.Data.Entity
    internal class ChinookContext : DbContext
    {
          //Pass the connection string name to the
          // DbContext using :base()
          //i.e. connection striing name is "chinookDB"
        public ChinookContext() :base("ChinookDB")
        {
            
        }
        //Setup all DbSet properties once Entity classes are created
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}








