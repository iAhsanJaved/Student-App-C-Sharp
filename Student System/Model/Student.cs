using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Model
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string DOB { get; set; }
        public int CityID { get; set; }
        public int LocalityID { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public int FundType { get; set; }
        public int FeeType { get; set; }
    }
}
