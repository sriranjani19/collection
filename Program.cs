
   
using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the problem of collection using lambda");
            Console.WriteLine();
            List<Person> listPerson = new List<Person>();
            AddRecords(listPerson);

            //FindThePersonByName(listPerson);
            //FindThePersonByAddress(listPerson);
            CheckPersonByCity(listPerson);
            //CheckPhoneNumberPersonPresentOrNot(listPerson);

        }
        private static void AddRecords(List<Person> listPerson)
        {
            listPerson.Add(new Person("6932587473", "sri", "Gangnapur,nadia", "ranjani", "Bihar", "824125", "sri@gmail.com"));
            listPerson.Add(new Person("8745548596", "madhan", "Gangr,nadia", "kumar", "Bihar", "824122", "sri@gmail.com"));
            listPerson.Add(new Person("8747845779", "vasu", "Gopinaur,nadia", "mathy", "Assam", "824555", "sri@gmail.com"));
            listPerson.Add(new Person("8745848528", "sowmi", "Linpapur,nadia", "para", "tamilnadhu", "888125", "sri@gmail.com"));
            listPerson.Add(new Person("8746547423", "Anbu", "Santinapur,nadia", "arasan", "Mp", "821125", "sri@gmail.com"));
            listPerson.Add(new Person("8745048357", "harini", "Mompur,nadia", "sri", "manipur", "824655", "sri@gmail.com"));
            listPerson.Add(new Person("8745703570", "hari", "Kannapur,nadia", "haran", "uttrakhand", "878125", "sri@gmail.com"));
            listPerson.Add(new Person("6296582055", "badari", "RajaRHut,nadia", "chow", "maharastra", "824745", "sri@gmail.com"));

        }
        //UC-7
        private static void FindThePersonByName(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => e.Name == "Anbu"))
            {
                Console.WriteLine("Phone Number :" + person.PhoneNo + " Name :" + person.Name);
            }
        }

        //UC-8
        private static void FindThePersonByAddress(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => e.Address == "Gangnapur,nadia"))
            {
                Console.WriteLine("Phone Number :" + person.PhoneNo + " Name :" + person.Name);
            }
        }


        //UC-9
        private static void CheckPersonByCity(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => e.City == "arwal"))
            {
                Console.WriteLine(" Name :" + person.Name);
            }

        }


        //UC-10
        private static void CheckPhoneNumberPersonPresentOrNot(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => e.PhoneNo == "6296582055"))
            {
                Console.WriteLine("Name :" + person.Name + "Address :" + person.Address);
            }
        }
    }
}
