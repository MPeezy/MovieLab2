using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLAB1
{
    public class Secret
    {
        public static string connection { get; set; } = $"server=127.0.0.1;uid=root;pwd=abc123;database=moviedb";
    }
}
