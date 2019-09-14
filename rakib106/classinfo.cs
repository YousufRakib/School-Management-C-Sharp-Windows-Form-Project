using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rakib106
{
    class resultinfo
    {
        public int[] R2016;
        public int[] R2015;
        public int[] R2014;
        public resultinfo(int[] a,int[] b,int[] c)
        {
            R2016 = a;
            R2015 = b;
            R2014 = c;
        } 
        public string R_2016()
        {
            return "Total subject: 6..Total student :3..There result are: ";
        }
        public string R_2016_student_1()
        {
            if (R2016[0] > 474)
                return"Student :1..Total marks :500..Grade : A+..This student get scolarship";
            else if (R2016[0] > 414 && R2016[0] < 480)
                return"Student :1..Total marks :500..Grade : A";
            else if (R2016[0] > 354 && R2016[0] < 420)
                return "Student :1..Total marks :500..Grade : A-";
            else if (R2016[0] > 294 && R2016[0] < 360)
                return "Student :1..Total marks :500..Grade : B";
            else if (R2016[0] > 234 && R2016[0] < 300)
                return "Student :1..Total marks :500..Grade : C";
            else if (R2016[0] > 192 && R2016[0] < 240)
                return "Student :1..Total marks :500..Grade : D";          
            else
                return "Student :1..Total marks :500..Grade : F";
        }
        public string R_2016_student_2()
        {
            if (R2016[0] > 474)
                return "Student :2..Total marks :470..Grade : A+..This student get scolarship";
            else if (R2016[1] > 414 && R2016[1] < 480)
                return "Student :2..Total marks :470..Grade : A";
            else if (R2016[1] > 354 && R2016[1] < 420)
                return "Student :2..Total marks :470..Grade : A-";
            else if (R2016[1] > 294 && R2016[1] < 360)
                return "Student :2..Total marks :470..Grade : B";
            else if (R2016[1] > 234 && R2016[1] < 300)
                return "Student :2..Total marks :470..Grade : C";
            else if (R2016[1] > 192 && R2016[1] < 240)
                return "Student :2..Total marks :470..Grade : D";
            else
                return "Student :2..Total marks :470..Grade : F";
        }
        public string R_2016_student_3()
        {
            if (R2016[2] > 474)
                return "Student :3..Total marks :400..Grade : A+..This student get scolarship";
            else if (R2016[2] > 414 && R2016[2] < 480)
                return "Student :3..Total marks :400..Grade : A";
            else if (R2016[2] > 354 && R2016[2] < 420)
                return "Student :3..Total marks :400..Grade : A-";
            else if (R2016[2] > 294 && R2016[2] < 360)
                return "Student :3..Total marks :400..Grade : B";
            else if (R2016[2] > 234 && R2016[2] < 300)
                return "Student :3..Total marks :400..Grade : C";
            else if (R2016[2] > 192 && R2016[2] < 240)
                return "Student :3..Total marks :400..Grade : D";
            else
                return "Student :3..Total marks :400..Grade : F";
        }
        public string R_2015()
        {
            return "Total subject: 6..Total student :3..There result are: ";
        }
        public string R_2015_student_1()
        {
            if (R2015[0] > 474)
                return "Student :1..Total marks :390..Grade : A+..This student get scolarship";
            else if (R2015[0] > 414 && R2015[0] < 480)
                return "Student :1..Total marks :390..Grade : A";
            else if (R2015[0] > 354 && R2015[0] < 420)
                return "Student :1..Total marks :390..Grade : A-";
            else if (R2015[0] > 294 && R2015[0] < 360)
                return "Student :1..Total marks :390..Grade : B";
            else if (R2015[0] > 234 && R2015[0] < 300)
                return "Student :1..Total marks :390..Grade : C";
            else if (R2015[0] > 192 && R2015[0] < 240)
                return "Student :1..Total marks :390..Grade : D";
            else
                return "Student :1..Total marks :390..Grade : F";
        }
        public string R_2015_student_2()
        {
            if (R2015[1] > 474)
                return "Student :2..Total marks 530..Grade : A+..This student get scolarship";
            else if (R2015[1] > 414 && R2015[1] < 480)
                return "Student :2..Total marks :530..Grade : A";
            else if (R2015[1] > 354 && R2015[1] < 420)
                return "Student :2..Total marks :530..Grade : A-";
            else if (R2015[1] > 294 && R2015[1] < 360)
                return "Student :2..Total marks :530..Grade : B";
            else if (R2015[1] > 234 && R2015[1] < 300)
                return "Student :2..Total marks :530..Grade : C";
            else if (R2015[1] > 192 && R2015[1] < 240)
                return "Student :2..Total marks :530..Grade : D";
            else
                return "Student :2..Total marks :530..Grade : F";
        }
        public string R_2015_student_3()
        {
            if (R2015[2] > 474)
                return "Student :3..Total marks :400..Grade : A+..This student get scolarship";
            else if (R2015[2] > 414 && R2015[2] < 480)
                return "Student :3..Total marks :400..Grade : A";
            else if (R2015[2] > 354 && R2015[2] < 420)
                return "Student :3..Total marks :400..Grade : A-";
            else if (R2015[2] > 294 && R2015[2] < 360)
                return "Student :3..Total marks :400..Grade : B";
            else if (R2015[2] > 234 && R2015[2] < 300)
                return "Student :3..Total marks :400..Grade : C";
            else if (R2015[2] > 192 && R2015[2] < 240)
                return "Student :3..Total marks :400..Grade : D";
            else
                return "Student :3..Total marks :400..Grade : F";
        }
        public string R_2014()
        {
            return "Total subject: 6..Total student :3..There result are: ";
        }
        public string R_2014_student_1()
        {
            if (R2014[0] > 474)
                return "Student :1..Total marks :400..Grade : A+..This student get scolarship";
            else if (R2014[0] > 414 && R2014[0] < 480)
                return "Student :1..Total marks :3400..Grade : A";
            else if (R2014[0] > 354 && R2014[0] < 420)
                return "Student :1..Total marks :400..Grade : A-";
            else if (R2014[0] > 294 && R2014[0] < 360)
                return "Student :1..Total marks :400..Grade : B";
            else if (R2014[0] > 234 && R2014[0] < 300)
                return "Student :1..Total marks :3400..Grade : C";
            else if (R2014[0] > 192 && R2014[0] < 240)
                return "Student :1..Total marks :400..Grade : D";
            else
                return "Student :1..Total marks :390..Grade : F";
        }
        public string R_2014_student_2()
        {
            if (R2014[1] > 474)
                return "Student :2..Total marks 460..Grade : A+..This student get scolarship";
            else if (R2014[1] > 414 && R2014[1] < 480)
                return "Student :2..Total marks :460..Grade : A";
            else if (R2014[1] > 354 && R2014[1] < 420)
                return "Student :2..Total marks :460..Grade : A-";
            else if (R2014[1] > 294 && R2014[1] < 360)
                return "Student :2..Total marks :460..Grade : B";
            else if (R2014[1] > 234 && R2014[1] < 300)
                return "Student :2..Total marks :460..Grade : C";
            else if (R2014[1] > 192 && R2014[1] < 240)
                return "Student :2..Total marks :460..Grade : D";
            else
                return "Student :2..Total marks :530..Grade : F";
        }
        public string R_2014_student_3()
        {
            if (R2014[2] > 474)
                return "Student :3..Total marks :450..Grade : A+..This student get scolarship";
            else if (R2014[2] > 414 && R2014[2] < 480)
                return "Student :3..Total marks :450..Grade : A";
            else if (R2014[2] > 354 && R2014[2] < 420)
                return "Student :3..Total marks :450..Grade : A-";
            else if (R2014[2] > 294 && R2014[2] < 360)
                return "Student :3..Total marks :450..Grade : B";
            else if (R2014[2] > 234 && R2014[2] < 300)
                return "Student :3..Total marks :450..Grade : C";
            else if (R2014[2] > 192 && R2014[2] < 240)
                return "Student :3..Total marks :450..Grade : D";
            else
                return "Student :3..Total marks :450..Grade : F";
        }
    }
}
