using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  public  class TESTER
    {
        private string id;
        private string familyname;
        private string name;
        private string birthdate;
        private string sex;
        private string tel;
        address address;
        private int experience;
        private int maxtests;
        private string kindofcar;
        private bool[,] arr = new bool[5, 6];
        private float distance;

        public override string ToString(string id)
        {
            List<TESTER> te = new List<TESTER>();
            ; try
            {
                TESTER temp = te.Find(item => item.id == id);
                if (temp != null)
                    te.Remove(temp);
            }
            
            return "id:" + "familyname" + familyname + "name" + name + "birthdate:" 
                + birthdate + "sex:" + sex + "tel" + tel + "address"+address+ "experience"+experience+"maxtests"+maxtests
                +"kindofcar"+kindofcar;


        }
       


    }
}
