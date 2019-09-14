using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rakib106
{
    class teacherinfo
    {
        public string[] Teacher_Name;
        public string[] T_degree;
        public string[] T_phoneNumber;
        public string[] T_address;
        public string[] T_salary;
        
        public teacherinfo(string[] a, string[] b, string[] c, string[] d, string[] e)
        {
            Teacher_Name = a;
            T_degree = b;
            T_phoneNumber = c;
            T_address = d;
            T_salary = e;        
        }
        public string Teacher1()
        {
            
                return "Mr.Kalam :...\nQualification :B.B.A\nPhone Number :01714567888\nDistrict :Noakhali\nSalary : 23000 Tk";
            
        }
        public string Teacher2()
        {
            
                return "Mr.Rana :...\nQualification :B.Sc\nPhone Number :01714567888\nDistrict :Khulna\nSalary :24000 Tk";
           
        }
        public string Teacher3()
        {
    
                return "Mr.Rahim :...\nQualification :H.S.C\nPhone Number :01819876590\nDistrict :Luxmipur\nSalary :15000 Tk";
            
        }



    }
}
