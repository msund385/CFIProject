using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFIProject.Models;

namespace CFIProject
{
    public interface IOhioRepo
    {
        public IEnumerable<OhioModels> GetAllOhio();
        public void UpdateAllOhio(OhioModels ohio);

        public OhioModels GetAllOhio(int id);







    }
}
