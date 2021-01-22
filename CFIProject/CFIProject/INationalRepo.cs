using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFIProject.Models;

namespace CFIProject
{
    public  interface INationalRepo
    {
        public IEnumerable<National> GetAllNational();
        public void UpdateNational(National national);

        public National GetNational(int id);

        
        
    }
    

   
}
