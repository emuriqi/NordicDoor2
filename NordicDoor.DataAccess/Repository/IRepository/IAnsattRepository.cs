using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NordicDoor.Models;
using NordicDoorWeb.Models;

namespace NordicDoor.DataAccess.Repository.IRepository
{
    public interface IAnsattRepository : IRepository<AnsattModel>
    {
        void Update(AnsattModel obj);
    }
}
