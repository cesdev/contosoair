using ContosoAir.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Repository
{
    public class BookRepository
    {
        private readonly UnitOfWork _db;
        public BookRepository(UnitOfWork db)
        {
            _db = db;
        }

        public void Save(UserBooks newitem) {

            _db.Books.InsertOne(newitem);
        }

        public List<UserBooks> GetByUser(string username) {

            return _db.Books.FindSync(b => b.UserName == username).ToList();
        }
    }
}
