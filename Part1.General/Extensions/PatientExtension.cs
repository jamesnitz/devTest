using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.General.Extensions
{
    public static class PatientExtension
    {
       public static string Serialize(this Patient patient)
        {
            return JsonConvert.SerializeObject(patient);
        }
    }
}
