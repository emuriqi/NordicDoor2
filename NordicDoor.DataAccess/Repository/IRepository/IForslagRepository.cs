using NordicDoor.Models;
using NordicDoorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.DataAccess.Repository.IRepository
{
    public interface IForslagRepository : IRepository<ForslagModel>
    {
        void Update(ForslagModel obj);
    }



}
