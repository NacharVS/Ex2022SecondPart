using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondWpf.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Balance { get; set; }

        public User()
        {
            Balance = 500;
        }
    }
}
