using CFIProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Microsoft.Owin.BuilderProperties;

namespace CFIProject
{
    public class NationalRepo : INationalRepo
    {
        public readonly IDbConnection _conn;

        public NationalRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<National> GetAllNational()
        {
            return _conn.Query<National>("SELECT * FROM national;");
        }
        public void UpdateNational(National national)
        {
            _conn.Execute("UPDATE national SET Name = @name,Address = @address,Website = @website, Phone = @phone,Email = @email,Assistance = @assistance WHERE ID = @id;",
                new { name = national.Name, address = national.Address, Website = national.Website, phone = national.Phone, email = national.Email, id = national.ID });
        }
        public National GetNational(int id)
        {
            return _conn.QuerySingle<National>("SELECT * FROM National WEHERE ID =@id", new { id = id });
        }


       
    }
}






