using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional Namespaces
using System.Data.Entity;
#endregion
namespace ChinookSystem.DAL
{
    // this is an internal class for security reasons
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
    }
}








