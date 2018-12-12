using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Trainee
    {
        public string Id { get; set; }
        private string id;
        private string familyname;
        private string name;
        private string birthdate;
        private string sex;
        private string tel;
        address address;
        private int countests;
        private string kindofcar;
        private string transmision;
        private string teachername;
        private int sumlessons;
        private string scholname;
        public Trainee()
        {
                
        }
        

        public override string ToString()
        {
            return "id:" + "familyname" + familyname + "name" + name + "birthdate:"
               + birthdate + "sex:" + sex + "tel" + tel + "address" + address + "transmision" + transmision + "teachername" + teachername
               + "sumlessons" + sumlessons + "scholname" + scholname+"countests"+countests+"kindofcar"+kindofcar;
        }




    }
}
