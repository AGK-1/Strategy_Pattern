using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Str_patterns
{
    public interface SvoyStrategy
    {
        void Payt(decimal amount);
        //public Svoy(string v) 
        //{
        //    v = cek;
        //}
        //public string cek {  get; set; }
    }
}
