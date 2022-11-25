using NordicDoor.DataAccess.Repository.IRepository;
using NordicDoor.Models;
using NordicDoorWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.DataAccess.Repository
{
    public class ForslagRepository : Repository<ForslagModel>, IForslagRepository
    {
        private ApplicationDbContext _db;


        public ForslagRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ForslagModel obj)
        {
            var objFromDb = _db.Forslags.FirstOrDefault(u => u.ForslagID== obj.ForslagID);
            if (objFromDb != null)
            {
                objFromDb.ForslagID= obj.ForslagID;
                objFromDb.AnsattID= obj.AnsattID;
                objFromDb.Tittel= obj.Tittel;
                objFromDb.NyttForslag= obj.NyttForslag;
                objFromDb.Årsak = obj.Årsak;
                objFromDb.Mål= obj.Mål;
                objFromDb.Løsning = obj.Løsning;
                objFromDb.DatoRegistrert= obj.DatoRegistrert;
                objFromDb.Frist= obj.Frist;
                objFromDb.Team= obj.Team;
                objFromDb.Ansavarlig= obj.Ansavarlig;
                if(obj.ImageUrl!=null)
                {
                    objFromDb.ImageUrl= obj.ImageUrl;
                }
            }
        }



    }
}

    

