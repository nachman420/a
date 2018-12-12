using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    
        public interface Idal
        {
            void addtester(TESTER ZAB );
            void deletester(string id);
            void updatetester(string id, string familyname, string name, string birthdate, string sex, string tel, BE.address address, int experience, int maxtests, string kindofcar, float distance);


            void addstudent(Trainee zab);
            void deletstudent(string id);
            void updatastudent(string id, string familyname, string name, string birthdate, string sex, string tel, BE.address address, int countests, string kindofcar, string transmision, string teachername, int sumlessons, string scholname);


            void addtest(Test ZAB);
            void updatefinaltest(int testID, int testerID, int studentID, string datetest, string dataehourtest, string testaddress, bool distance, bool reversparking, bool mirrors, bool vinkers, bool gread, string note);


              void setesterlist(List<BE.TESTER> list);
              void   setstudentlist(List<BE.Trainee> list);
              void  setestresult(List<BE.Test> list);
        }
    
}
