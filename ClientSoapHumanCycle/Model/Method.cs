using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSoapHumanCycle.ServiceReference1;

namespace ClientSoapHumanCycle.Model
{
    class Method : IMethod
    {

        ServiceReference1.Service1Client stub = new ServiceReference1.Service1Client();

        public Method()
        {
            stub = new ServiceReference1.Service1Client();
        }


        public List<Human> UpdateStepOne(Human[] humen)
        {
            List <Human> humen02 = new List<Human>();

            

            //I transfert the board to the list
            for (int i=0;i< humen.Length; i++)
            {
                humen02.Add(humen[i]);
                //Console.WriteLine("slice number : " + humen[i].Slice.Number);
                Console.WriteLine("name : " + humen[i].FirstName);
            }

            //for each slice I update number +1
            for(int i=0;i< humen02.Count; i++)
            {
                //humen02[i].Slice.Number = (humen02[i].Slice.Number + 1);
            }

            return humen02;
        }
    }
}
