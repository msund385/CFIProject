using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CFIProject.Models;
using Dapper;

namespace CFIProject
{
    public class OhioRepo : IOhioRepo
    {
        private readonly IDbConnection _conn;

        public OhioRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<OhioModels> GetAllOhio()
        {
            return _conn.Query<OhioModels>("SELECT * from ohio;"); 


        }
        public void UpdateOhio(OhioModels ohio)
        {
            _conn.Execute("UPDATE ohio SET Name = @name,Address = @address,Website = @website, Phone = @phone,Email = @email,Assistance = @assistance WHERE ID = @id",
                new { name = ohio.ohio_Name, address = ohio.ohio_Address, Website = ohio.ohio_Website, phone = ohio.ohio_Phone, email = ohio.ohio_Email, id = ohio.ohio_ID });
        }

        public OhioModels GetAllOhio(int id)
        {
            return _conn.QuerySingle<OhioModels>("SELECT * FROM ohio WEHERE ID =@id", new { id = id });
        }

        public void UpdateAllOhio(OhioModels ohio)
        {
            throw new NotImplementedException();
        }
    }

}



