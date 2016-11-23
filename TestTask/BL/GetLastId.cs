using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.BL
{
    public static class GetLastId
    {
        public static int GetId()
        {
            var employes = ReturnEmployes.Get();
            int id = 0;

            if (employes!=null)
            {
                foreach (var emp in employes)
                {
                    if (emp.Id>id)
                    {
                        id = emp.Id;
                    }
                }
            }

            
            return id + 1;
        }
    }
}
