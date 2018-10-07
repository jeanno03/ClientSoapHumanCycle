using ClientSoapHumanCycle.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSoapHumanCycle.Tool
{
    class Data
    {

        ServiceReference1.Service1Client stub = new ServiceReference1.Service1Client();

        public void DataTest()
        {
            Human hu01 = new Human() { LastName = "Brice", FirstName = "DeNice" };
            Human hu02 = new Human() { LastName = "Sam", FirstName = "MeVa" };
            Human hu03 = new Human() { LastName = "Tina", FirstName = "Dorteur" };
            Human hu04 = new Human() { LastName = "Patrick", FirstName = "Brubru" };
            Human hu05 = new Human() { LastName = "Malissa", FirstName = "LaMalisse" };
            Human hu06 = new Human() { LastName = "Rama", FirstName = "Wade" };
            Human hu07 = new Human() { LastName = "Lebron", FirstName = "Kanes" };
            Human hu08 = new Human() { LastName = "Vince", FirstName = "Vainqueur" };
            Human hu09 = new Human() { LastName = "Roberto", FirstName = "Donoro" };
            Human hu10 = new Human() { LastName = "Sarah", FirstName = "Croche" };

            Town to01 = new Town() { Number = 1, Name = "Sannois" };
            Town to02 = new Town() { Number = 2, Name = "Paris" };
            Town to03 = new Town() { Number = 3, Name = "Londres" };

            Slice si01 = new Slice() { Number = 1, Name = "Kid" };
            Slice si02 = new Slice() { Number = 2, Name = "Young adult" };
            Slice si03 = new Slice() { Number = 3, Name = "Adult" };
            Slice si04 = new Slice() { Number = 4, Name = "Mature" };
            Slice si05 = new Slice() { Number = 5, Name = "Inactive" };

            Gender ge01 = new Gender() { Number = 1, Name = "Male" };
            Gender ge02 = new Gender() { Number = 2, Name = "Female" };

            Statut st01 = new Statut() { Number = 1, Name = "Living" };
            Statut st02 = new Statut() { Number = 2, Name = "Dead" };

            //vivant à Sannois
            hu01.Town = to01;
            hu02.Town = to01;
            hu03.Town = to01;

            //vivant à Paris
            hu04.Town = to02;
            hu05.Town = to02;
            hu06.Town = to02;
            hu07.Town = to02;

            //vivant à Londres
            hu08.Town = to03;
            hu09.Town = to03;
            hu10.Town = to03;

            //Kid
            hu01.Slice = si01;
            hu02.Slice = si01;
            hu03.Slice = si01;
            hu04.Slice = si01;
            hu05.Slice = si01;
            hu06.Slice = si01;

            //Young adult
            hu07.Slice = si02;
            hu08.Slice = si02;
            hu09.Slice = si02;
            hu10.Slice = si02;

            //Male
            hu01.Gender = ge01;
            hu04.Gender = ge01;
            hu07.Gender = ge01;
            hu08.Gender = ge01;
            hu09.Gender = ge01;

            //Female
            hu02.Gender = ge02;
            hu03.Gender = ge02;
            hu05.Gender = ge02;
            hu06.Gender = ge02;
            hu10.Gender = ge02;

            //Living
            hu01.Statut = st01;
            hu02.Statut = st01;
            hu03.Statut = st01;
            hu04.Statut = st01;
            hu05.Statut = st01;
            hu06.Statut = st01;
            hu07.Statut = st01;
            hu08.Statut = st01;
            hu09.Statut = st01;
            hu10.Statut = st01;

            Town[] towns = new Town[3];
            towns[0] = to01;
            towns[1] = to02;
            towns[2] = to03;

            Slice[] slices = new Slice[5];
            slices[0] = si01;
            slices[1] = si02;
            slices[2] = si03;
            slices[3] = si04;
            slices[4] = si05;

            Gender[] genders = new Gender[2];
            genders[0] = ge01;
            genders[1] = ge02;

            Statut[] statuts = new Statut[2];
            statuts[0] = st01;
            statuts[1] = st02;

            Human[] humen = new Human[10];
            humen[0] = hu01;
            humen[1] = hu02;
            humen[2] = hu03;
            humen[3] = hu04;
            humen[4] = hu05;
            humen[5] = hu06;
            humen[6] = hu07;
            humen[7] = hu08;
            humen[8] = hu09;
            humen[9] = hu10;


            stub.InsertTownList(towns);
            stub.InsertSliceList(slices);
            stub.InsertGenderList(genders);
            stub.InsertStatutList(statuts);
            stub.InsertHumanList(humen);
        }
    }
}
