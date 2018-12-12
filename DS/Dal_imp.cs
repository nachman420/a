using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace DS
{
    class Dal_imp : Idal 
    {
        DataSource DataSource = new DataSource();

        public void addstudent(Trainee newStudent)
        {
            
           

            if (         DataSource.listraine.Any(item => item.Id ==newStudent.Id))
            {
                DataSource.listraine.Add(newStudent);
            }
           
        }

        public void addtest(Test ZAB)
        {
            
        }  

        public void addtester(string id, string familyname, string name, string birthdate, string sex, string tel, address address, int experience, int maxtests, string kindofcar, float distance)
        {
            throw new NotImplementedException();
        }

        public void deletester(string id)
        {
            throw new NotImplementedException();
        }

        public void deletstudent(string id)
        {
            throw new NotImplementedException();
        }

        public void getesterlist(List<TESTER> list)
        {
            throw new NotImplementedException();
        }

        public void getestresult(List<Test> list)
        {
            throw new NotImplementedException();
        }

        public void getstudentlist(List<Trainee> list)
        {
            throw new NotImplementedException();
        }

        public void setesterlist(List<TESTER> list)
        {
            throw new NotImplementedException();
        }

        public void setestresult(List<Test> list)
        {
            throw new NotImplementedException();
        }

        public void setstudentlist(List<Trainee> list)
        {
            throw new NotImplementedException();
        }

        public void updatastudent(string id, string familyname, string name, string birthdate, string sex, string tel, address address, int countests, string kindofcar, string transmision, string teachername, int sumlessons, string scholname)
        {
            throw new NotImplementedException();
        }

        public void updatefinaltest(int testID, int testerID, int studentID, string datetest, string dataehourtest, string testaddress, bool distance, bool reversparking, bool mirrors, bool vinkers, bool gread, string note)
        {
            throw new NotImplementedException();
        }

        public void updatetester(string id, string familyname, string name, string birthdate, string sex, string tel, address address, int experience, int maxtests, string kindofcar, float distance)
        {
            throw new NotImplementedException();
        }
    }
}
