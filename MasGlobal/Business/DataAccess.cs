using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MasGlobal.Models;

namespace MasGlobal
{
    class DataAccess
    {
        public List<DtoEmployee> get(string url)
        {


            List<DtoEmployee> res;
            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);

            using (var response = webrequest.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {

                var result = reader.ReadToEnd();
                res = JsonConvert.DeserializeObject<List<DtoEmployee>>(result);
            }


            foreach (DtoEmployee emp in res)
            {
                Employees GetAnualSalary = Creator.CreatorSalary(emp.contractTypeName);
                 emp.anualSalary = GetAnualSalary.AnualSalary(emp.hourlySalary, emp.monthlySalary);

            }
            

            return res;
        }
    }
}
