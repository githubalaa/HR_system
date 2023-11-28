using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaa_HR_sys
{
    internal class mr_stat
    {
        public int Id { get; set; }
        public string? mr_Name { get; set; }
        public mr_stat(int id, string ms)
        {
            Id = id;
            mr_Name = ms;
        }
        public mr_stat()
        {
        }
    }
}
