


namespace HW01_Define_a_Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    class TestGSM
    {
        public void CreateFewGSMs()
        {

            GSM firstGsm = new GSM("S45", "Siemens");
            GSM secondGsm = new GSM("5410", "Nokia");
            GSM thirdGsm = new GSM("Galaxy", "Samsung", 800);

            GSM[] gsms = new GSM[3] { firstGsm, secondGsm, thirdGsm };

            for (int i = 0; i < gsms.Length; i++)
            {
                gsms[i].DisplayGSMInfo();
            }

        }

    }
}

