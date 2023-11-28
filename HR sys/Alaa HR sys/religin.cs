using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaa_HR_sys
{
    internal class religin
    {
        public int Id { get; set; }
        public string? r_Name { get; set; }
        public religin(int id, string re)
        {
            Id = id;
            r_Name = re;
        }
        public religin()
        {
        }
    }
}
