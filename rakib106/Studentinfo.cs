using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rakib106
{
    class Studentinfo
    {
        public int[] OneResult;
        public int[] TwoResult;
        public int[] ThreeResult;
        public int[] FourResult;
        public int[] FiveResult;
        public Studentinfo(int[] f, int[] g, int[] h, int[] i, int[] j)
        {
            OneResult = f;
            TwoResult = g;
            ThreeResult = h;
            FourResult = i;
            FiveResult = j;
        }
        public string class1info()
        {
            return"Class One :...Total subject :6..Total student :4\nThere salary :250 Tk\nThere result are :";
        }
        public string class1_student_1()
        { 
                if (OneResult[0] > 474)
                    return"Student :1..Total marks :335..Grade : A+";
                else if (OneResult[0] > 414 && OneResult[0] < 480)
                return "Student :1..Total marks :335..Grade : A";
                else if (OneResult[0] > 354 && OneResult[0] < 420)
                return "Student :1..Total marks :335..Grade : A-";
                else if (OneResult[0] > 294 && OneResult[0] < 360)
                return "Student :1..Total marks :335..Grade : B";
                else if (OneResult[0] > 234 && OneResult[0] < 300)
                return "Student :1..Total marks :335..Grade : C";
                else if (OneResult[0] > 192 && OneResult[0] < 240)
                return "Student :1..Total marks :335..Grade : D";
                else
                return "Student :1..Total marks :335..Grade : F";
        }
        public string class1_student_2()
        {
            if (OneResult[1] > 474)
                return "Student :2..Total marks :480..Grade : A+";
            else if (OneResult[1] > 414 && OneResult[1] < 480)
                return "Student :2..Total marks :480..Grade : A";
            else if (OneResult[1] > 354 && OneResult[1] < 420)
                return "Student :2..Total marks :480..Grade : A-";
            else if (OneResult[1] > 294 && OneResult[1] < 360)
                return "Student :2..Total marks :480..Grade : B";
            else if (OneResult[1] > 234 && OneResult[1] < 300)
                return "Student :2..Total marks :480..Grade : C";
            else if (OneResult[1] > 192 && OneResult[1] < 240)
                return "Student :2..Total marks :480..Grade : D";
            else
                return "Student :2..Total marks :480..Grade : F";
        }
        public string class1_student_3()
        {
            if (OneResult[2] > 474)
                return "Student :3..Total marks :425..Grade : A+";
            else if (OneResult[2] > 414 && OneResult[2] < 480)
                return "Student :3..Total marks :425..Grade : A";
            else if (OneResult[2] > 354 && OneResult[2] < 420)
                return "Student :3..Total marks :425..Grade : A-";
            else if (OneResult[2] > 294 && OneResult[2] < 360)
                return "Student :3..Total marks :425..Grade : B";
            else if (OneResult[2] > 234 && OneResult[2] < 300)
                return "Student :3..Total marks :425..Grade : C";
            else if (OneResult[2] > 192 && OneResult[2] < 240)
                return "Student :3..Total marks :425..Grade : D";
            else
                return "Student :3..Total marks :480..Grade : F";
        }
        public string class1_student_4()
        {
            if (OneResult[3] > 474)
                return "Student :4..Total marks :365..Grade : A+";
            else if (OneResult[3] > 414 && OneResult[3] < 480)
                return "Student :4..Total marks :365..Grade : A";
            else if (OneResult[3] > 354 && OneResult[3] < 420)
                return "Student :4..Total marks :365..Grade : A-";
            else if (OneResult[3] > 294 && OneResult[3] < 360)
                return "Student :4..Total marks :365..Grade : B";
            else if (OneResult[3] > 234 && OneResult[3] < 300)
                return "Student :4..Total marks :365..Grade : C";
            else if (OneResult[3] > 192 && OneResult[3] < 240)
                return "Student :4..Total marks :365..Grade : D";
            else
                return "Student :4..Total marks :360..Grade : F";
        }
        public string class2info()
        {
            return "Class Two :...Total subject :6..Total student :4\nThere salary :300 Tk\nThere result are :";
        }
        public string class2_student_1()
        {
            if (OneResult[0] > 474)
                return "Student :1..Total marks :475..Grade : A+";
            else if (OneResult[0] > 414 && OneResult[0] < 480)
                return "Student :1..Total marks :475..Grade : A";
            else if (OneResult[0] > 354 && OneResult[0] < 420)
                return "Student :1..Total marks :475..Grade : A-";
            else if (OneResult[0] > 294 && OneResult[0] < 360)
                return "Student :1..Total marks :475..Grade : B";
            else if (OneResult[0] > 234 && OneResult[0] < 300)
                return "Student :1..Total marks :475..Grade : C";
            else if (OneResult[0] > 192 && OneResult[0] < 240)
                return "Student :1..Total marks :475..Grade : D";
            else
                return "Student :1..Total marks :475..Grade : F";
        }
        public string class2_student_2()
        {
            if (OneResult[1] > 474)
                return "Student :2..Total marks :380..Grade : A+";
            else if (OneResult[1] > 414 && OneResult[1] < 480)
                return "Student :2..Total marks :380..Grade : A";
            else if (OneResult[1] > 354 && OneResult[1] < 420)
                return "Student :2..Total marks :380..Grade : A-";
            else if (OneResult[1] > 294 && OneResult[1] < 360)
                return "Student :2..Total marks :380..Grade : B";
            else if (OneResult[1] > 234 && OneResult[1] < 300)
                return "Student :2..Total marks :380..Grade : C";
            else if (OneResult[1] > 192 && OneResult[1] < 240)
                return "Student :2..Total marks :380..Grade : D";
            else
                return "Student :2..Total marks :380..Grade : F";
        }
        public string class2_student_3()
        {
            if (OneResult[2] > 474)
                return "Student :3..Total marks :278..Grade : A+";
            else if (OneResult[2] > 414 && OneResult[2] < 480)
                return "Student :3..Total marks :278..Grade : A";
            else if (OneResult[2] > 354 && OneResult[2] < 420)
                return "Student :3..Total marks :278..Grade : A-";
            else if (OneResult[2] > 294 && OneResult[2] < 360)
                return "Student :3..Total marks :278..Grade : B";
            else if (OneResult[2] > 234 && OneResult[2] < 300)
                return "Student :3..Total marks :278..Grade : C";
            else if (OneResult[2] > 192 && OneResult[2] < 240)
                return "Student :3..Total marks :278..Grade : D";
            else
                return "Student :3..Total marks :278..Grade : F";
        }
        public string class2_student_4()
        {
            if (OneResult[3] > 474)
                return "Student :4..Total marks :280..Grade : A+";
            else if (OneResult[3] > 414 && OneResult[3] < 480)
                return "Student :4..Total marks :280..Grade : A";
            else if (OneResult[3] > 354 && OneResult[3] < 420)
                return "Student :4..Total marks :280..Grade : A-";
            else if (OneResult[3] > 294 && OneResult[3] < 360)
                return "Student :4..Total marks :280..Grade : B";
            else if (OneResult[3] > 234 && OneResult[3] < 300)
                return "Student :4..Total marks :280..Grade : C";
            else if (OneResult[3] > 192 && OneResult[3] < 240)
                return "Student :4..Total marks :280..Grade : D";
            else
                return "Student :4..Total marks :280..Grade : F";
        }
        public string class3info()
        {
            return "Class Three :...Total subject :6..Total student :4\nThere salary :350 Tk\nThere result are :";
        }
        public string class3_student_1()
        {
            if (OneResult[0] > 474)
                return "Student :1..Total marks :485..Grade : A+";
            else if (OneResult[0] > 414 && OneResult[0] < 480)
                return "Student :1..Total marks :485..Grade : A";
            else if (OneResult[0] > 354 && OneResult[0] < 420)
                return "Student :1..Total marks :485..Grade : A-";
            else if (OneResult[0] > 294 && OneResult[0] < 360)
                return "Student :1..Total marks :485..Grade : B";
            else if (OneResult[0] > 234 && OneResult[0] < 300)
                return "Student :1..Total marks :485..Grade : C";
            else if (OneResult[0] > 192 && OneResult[0] < 240)
                return "Student :1..Total marks :485..Grade : D";
            else
                return "Student :1..Total marks :485..Grade : F";
        }
        public string class3_student_2()
        {
            if (OneResult[1] > 474)
                return "Student :2..Total marks :420..Grade : A+";
            else if (OneResult[1] > 414 && OneResult[1] < 480)
                return "Student :2..Total marks :420..Grade : A";
            else if (OneResult[1] > 354 && OneResult[1] < 420)
                return "Student :2..Total marks :420..Grade : A-";
            else if (OneResult[1] > 294 && OneResult[1] < 360)
                return "Student :2..Total marks :420..Grade : B";
            else if (OneResult[1] > 234 && OneResult[1] < 300)
                return "Student :2..Total marks :420..Grade : C";
            else if (OneResult[1] > 192 && OneResult[1] < 240)
                return "Student :2..Total marks :420..Grade : D";
            else
                return "Student :2..Total marks :420..Grade : F";
        }
        public string class3_student_3()
        {
            if (OneResult[2] > 474)
                return "Student :3..Total marks :297..Grade : A+";
            else if (OneResult[2] > 414 && OneResult[2] < 480)
                return "Student :3..Total marks :297..Grade : A";
            else if (OneResult[2] > 354 && OneResult[2] < 420)
                return "Student :3..Total marks :297..Grade : A-";
            else if (OneResult[2] > 294 && OneResult[2] < 360)
                return "Student :3..Total marks :297..Grade : B";
            else if (OneResult[2] > 234 && OneResult[2] < 300)
                return "Student :3..Total marks :297..Grade : C";
            else if (OneResult[2] > 192 && OneResult[2] < 240)
                return "Student :3..Total marks :297..Grade : D";
            else
                return "Student :3..Total marks :297..Grade : F";
        }
        public string class3_student_4()
        {
            if (OneResult[3] > 474)
                return "Student :4..Total marks :188..Grade : A+";
            else if (OneResult[3] > 414 && OneResult[3] < 480)
                return "Student :4..Total marks :188..Grade : A";
            else if (OneResult[3] > 354 && OneResult[3] < 420)
                return "Student :4..Total marks :188..Grade : A-";
            else if (OneResult[3] > 294 && OneResult[3] < 360)
                return "Student :4..Total marks :188..Grade : B";
            else if (OneResult[3] > 234 && OneResult[3] < 300)
                return "Student :4..Total marks :188..Grade : C";
            else if (OneResult[3] > 192 && OneResult[3] < 240)
                return "Student :4..Total marks :188..Grade : D";
            else
                return "Student :4..Total marks :188..Grade : F";
        }
        public string class4info()
        {
            return "Class Four :...Total subject :6..Total student :4\nThere salary :400 Tk\nThere result are :";
        }
        public string class4_student_1()
        {
            if (OneResult[0] > 474)
                return "Student :1..Total marks :475..Grade : A+";
            else if (OneResult[0] > 414 && OneResult[0] < 480)
                return "Student :1..Total marks :475..Grade : A";
            else if (OneResult[0] > 354 && OneResult[0] < 420)
                return "Student :1..Total marks :475..Grade : A-";
            else if (OneResult[0] > 294 && OneResult[0] < 360)
                return "Student :1..Total marks :475..Grade : B";
            else if (OneResult[0] > 234 && OneResult[0] < 300)
                return "Student :1..Total marks :475..Grade : C";
            else if (OneResult[0] > 192 && OneResult[0] < 240)
                return "Student :1..Total marks :475..Grade : D";
            else
                return "Student :1..Total marks :475..Grade : F";
        }
        public string class4_student_2()
        {
            if (OneResult[1] > 474)
                return "Student :2..Total marks :390..Grade : A+";
            else if (OneResult[1] > 414 && OneResult[1] < 480)
                return "Student :2..Total marks :390..Grade : A";
            else if (OneResult[1] > 354 && OneResult[1] < 420)
                return "Student :2..Total marks :390..Grade : A-";
            else if (OneResult[1] > 294 && OneResult[1] < 360)
                return "Student :2..Total marks :390..Grade : B";
            else if (OneResult[1] > 234 && OneResult[1] < 300)
                return "Student :2..Total marks :390..Grade : C";
            else if (OneResult[1] > 192 && OneResult[1] < 240)
                return "Student :2..Total marks :390..Grade : D";
            else
                return "Student :2..Total marks :390..Grade : F";
        }
        public string class4_student_3()
        {
            if (OneResult[2] > 474)
                return "Student :3..Total marks :238..Grade : A+";
            else if (OneResult[2] > 414 && OneResult[2] < 480)
                return "Student :3..Total marks :238..Grade : A";
            else if (OneResult[2] > 354 && OneResult[2] < 420)
                return "Student :3..Total marks :238..Grade : A-";
            else if (OneResult[2] > 294 && OneResult[2] < 360)
                return "Student :3..Total marks :238..Grade : B";
            else if (OneResult[2] > 234 && OneResult[2] < 300)
                return "Student :3..Total marks :238..Grade : C";
            else if (OneResult[2] > 192 && OneResult[2] < 240)
                return "Student :3..Total marks :238..Grade : D";
            else
                return "Student :3..Total marks :238..Grade : F";
        }
        public string class4_student_4()
        {
            if (OneResult[3] > 474)
                return "Student :4..Total marks :200..Grade : A+";
            else if (OneResult[3] > 414 && OneResult[3] < 480)
                return "Student :4..Total marks :200..Grade : A";
            else if (OneResult[3] > 354 && OneResult[3] < 420)
                return "Student :4..Total marks :200..Grade : A-";
            else if (OneResult[3] > 294 && OneResult[3] < 360)
                return "Student :4..Total marks :200..Grade : B";
            else if (OneResult[3] > 234 && OneResult[3] < 300)
                return "Student :4..Total marks :200..Grade : C";
            else if (OneResult[3] > 192 && OneResult[3] < 240)
                return "Student :4..Total marks :200..Grade : D";
            else
                return "Student :4..Total marks :200..Grade : F";
        }
        public string class5info()
        {
            return "Class Five :...Total subject :6..Total student :3\nThere salary :500 Tk\nThere result are :";
        }
        public string class5_student_1()
        {
            if (OneResult[0] > 474)
                return "Student :1..Total marks :500..Grade : A+";
            else if (OneResult[0] > 414 && OneResult[0] < 480)
                return "Student :1..Total marks :500..Grade : A";
            else if (OneResult[0] > 354 && OneResult[0] < 420)
                return "Student :1..Total marks :500..Grade : A-";
            else if (OneResult[0] > 294 && OneResult[0] < 360)
                return "Student :1..Total marks :500..Grade : B";
            else if (OneResult[0] > 234 && OneResult[0] < 300)
                return "Student :1..Total marks :500..Grade : C";
            else if (OneResult[0] > 192 && OneResult[0] < 240)
                return "Student :1..Total marks :500..Grade : D";
            else
                return "Student :1..Total marks :500..Grade : F";
        }
        public string class5_student_2()
        {
            if (OneResult[1] > 474)
                return "Student :2..Total marks :470..Grade : A+";
            else if (OneResult[1] > 414 && OneResult[1] < 480)
                return "Student :2..Total marks :470..Grade : A";
            else if (OneResult[1] > 354 && OneResult[1] < 420)
                return "Student :2..Total marks :470..Grade : A-";
            else if (OneResult[1] > 294 && OneResult[1] < 360)
                return "Student :2..Total marks :470..Grade : B";
            else if (OneResult[1] > 234 && OneResult[1] < 300)
                return "Student :2..Total marks :470..Grade : C";
            else if (OneResult[1] > 192 && OneResult[1] < 240)
                return "Student :2..Total marks :470..Grade : D";
            else
                return "Student :2..Total marks :470..Grade : F";
        }
        public string class5_student_3()
        {
            if (OneResult[2] > 474)
                return "Student :3..Total marks :400..Grade : A+";
            else if (OneResult[2] > 414 && OneResult[2] < 480)
                return "Student :3..Total marks :400..Grade : A";
            else if (OneResult[2] > 354 && OneResult[2] < 420)
                return "Student :3..Total marks :400..Grade : A-";
            else if (OneResult[2] > 294 && OneResult[2] < 360)
                return "Student :3..Total marks :400..Grade : B";
            else if (OneResult[2] > 234 && OneResult[2] < 300)
                return "Student :3..Total marks :400..Grade : C";
            else if (OneResult[2] > 192 && OneResult[2] < 240)
                return "Student :3..Total marks :400..Grade : D";
            else
                return "Student :3..Total marks :400..Grade : F";
        }
    }
}
