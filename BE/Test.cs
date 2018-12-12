using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        int testID;
        int testerID;
        int studentID;
        string datetest;
        string dataehourtest;
        string testaddress;
        bool distance;
        bool reversparking;
        bool mirrors;
        bool vinkers;
        bool gread;
        string note;

        public override string ToString()
        {
            return "testID" + testID + "testerID" + testerID + "studentID" + studentID + "datetest" + datetest
                + "dataehourtest" + dataehourtest
                + "testaddress" + testaddress
                + "distance" + distance + "reversparking" + reversparking + "mirrors" + mirrors +
                "vinkers" + vinkers + "gread" + gread
                + "note" + note;
        }






    }
}
