using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaa_HR_sys
{
    internal class emp_status1
    {
            public int Id { get; set; }
        public string? emp_stat_Name { get; set; }
            public emp_status1(int id, string cn)
            {
                Id = id;
                emp_stat_Name = cn;
            }
            public emp_status1()
            {
            }

        }
    }
