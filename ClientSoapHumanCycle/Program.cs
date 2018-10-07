using ClientSoapHumanCycle.Model;
using ClientSoapHumanCycle.ServiceReference1;
using ClientSoapHumanCycle.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSoapHumanCycle
{
    class Program
    {

       

        static void Main(string[] args)
        {

            ServiceReference1.Service1Client stub = new ServiceReference1.Service1Client();
            IMethod method = new Method();

            //ServiceReference1.Service1Client stub = new ServiceReference1.Service1Client();
            //ServiceReference1.Human[] humen = stub.GetHumen();
            //for (int i = 0; i < humen.Length; i++)
            //{
            //    Console.WriteLine(humen[i].FirstName);
            //    Console.WriteLine(humen[i].LastName);
            //    Console.WriteLine("---------------");
            //    //Console.ReadLine();
            //}

            Data data = new Data();
            data.DataTest();
            Console.WriteLine("Data test sucesfull");

            ServiceReference1.Human[] humen = stub.GetHumen();
            for (int i = 0; i < humen.Length; i++)
            {
                Console.WriteLine("Nom : " + humen[i].FirstName);
                Console.WriteLine("Prénom: " + humen[i].LastName);
                Console.WriteLine("---------------");

            }

            method.UpdateStepOne(humen);

              // List<Human> humen02 =  method.UpdateStepOne(humen);
              //stub.UpdateHuman(humen);
            Console.WriteLine("Human update sucesfull");

            

            Console.ReadLine();

        }


        
    }
}
