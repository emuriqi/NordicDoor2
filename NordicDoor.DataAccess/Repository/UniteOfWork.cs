//using NordicDoor.DataAcces;
using NordicDoor.DataAccess.Repository.IRepository;
//using NordicDoor.Models;
using NordicDoorWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.DataAccess.Repository
{
    public class UniteOfWork : IUniteOfWork
    {
        private ApplicationDbContext _db;

        public UniteOfWork(ApplicationDbContext db)
        {
            _db = db;
            
            Ansatt = new AnsattRepository(_db);
        }
       
        public IAnsattRepository Ansatt { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
