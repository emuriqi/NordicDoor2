//using NordicDoor.DataAcces;
using NordicDoor.DataAccess.Repository.IRepository;
//using NordicDoor.Models;
using NordicDoorWeb.Data;
using NordicDoorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.DataAccess.Repository
{
    public class AnsattRepository : Repository<AnsattModel>, IAnsattRepository
    {
        private ApplicationDbContext _db;
       

        public AnsattRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       

        public void Update(AnsattModel obj)
        {
            var objFromDb = _db.Ansatte.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.Id = objFromDb.Id;
                objFromDb.Fornavn = objFromDb.Fornavn;
                objFromDb.Etternavn = objFromDb.Etternavn;
                objFromDb.Team = objFromDb.Team;
                objFromDb.Rolle = objFromDb.Rolle;
            }
        }
    }
}
