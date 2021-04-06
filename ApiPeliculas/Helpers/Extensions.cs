using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPeliculas.Helpers
{
    public static class Extensions
    {
       public static void AddApplicationError(this HttpResponse respose, string message)
        {
            respose.Headers.Add("Application-Error", message);
            respose.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            respose.Headers.Add("Access-Control-Allow-Origin", "*");

        }
    }
}
