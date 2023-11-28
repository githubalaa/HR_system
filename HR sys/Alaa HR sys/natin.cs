using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaa_HR_sys
{
    internal class natin
    {
        public char Id { get; set; }
        public string? n_Name { get; set; }
        public natin(char id, string na)
        {
            Id = id;
            n_Name = na;
        }
        public natin()
        {
        }
    }
}
