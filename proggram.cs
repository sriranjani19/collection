﻿using AddressBookLamdaDemo;
//using LamdaDemo;
using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        /// <summary>
        /// UC10_activated by sri.
        /// </summary>
        /// <param name="args">The arguments.</param>

        static void Main(string[] args)

        {

            Console.WriteLine("Welcome to My AddressBook Problem Using Lambda");
            List<Person> listPerson = new List<Person>();
            AddRecords(listPerson);
            //RecivingTwo_TopWords_ForAgeIs_LessThanSixty(listPerson);
            //Age_Between_ThirteenToEighteen(listPerson);
            //AvarageOfTheAge(listPerson);
            //CheckPersonPresentOrNot(listPerson);
            SkipThePersonIsLessThenSixty(listPerson);
            //FindThePersonByAddress(listPerson);
            // CheckPhoneNumberPersonPresentOrNot(listPerson);

        }

        private static void AddRecords(List<Person> listPerson)
        {
            listPerson.Add(new Person("6932587473", "sri", "Gangnapur,nadia", 55));
            listPerson.Add(new Person("8745548596", "madhan", "Gangr,nadia", 45));
            listPerson.Add(new Person("8747845779", "vasu", "Gopinaur,nadia", 17));
            listPerson.Add(new Person("8745848528", "sowmi", "Linpapur,nadia", 53));
            listPerson.Add(new Person("8746547423", "Anbu", "Santinapur,nadia", 93));
            listPerson.Add(new Person("8745048357", "harini", "Mompur,nadia", 60));
            listPerson.Add(new Person("8745703570", "hari", "Kannapur,nadia", 70));
            listPerson.Add(new Person("6296582055", "kumar", "RajaRHut,nadia", 95));
        }

        private static void RecivingTwo_TopWords_ForAgeIs_LessThanSixty(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name" + person.Name + "Age" + person.Age);
            }

        }

        private static void Age_Between_ThirteenToEighteen(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => (e.Age < 18 && e.Age > 13)).ToList())
            {
                Console.WriteLine("Name" + person.Name + "Age" + person.Age);
            }

        }

        private static void AvarageOfTheAge(List<Person> listPerson)
        {
            double aveAge = listPerson.Average(e => e.Age);
            Console.WriteLine("The total Person Average Age is :" + aveAge);
        }


        private static void CheckPersonPresentOrNot(List<Person> listPerson)
        {
            if (listPerson.Any(e => e.Name == "sri"))
            {
                Console.WriteLine("The Person is Present:");
            }
            else
            {
                Console.WriteLine("The person is not Present");
            }
        }
        //UC10
        private static void SkipThePersonIsLessThenSixty(List<Person> listPerson)
        {
            foreach (Person person in listPerson.SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine("Name" + person.Name + "Age" + person.Age);
            }
        }

        private static void FindThePersonByAddress(List<Person> listPerson)
        {
            //if (listPerson.Any(e => e.Address == "Gangnar,nadia"))
            //{
            //    Console.WriteLine("The Person is Present:");
            //}
            //else
            //{
            //    Console.WriteLine("The person is not Present");
            //}
            foreach (Person person in listPerson.FindAll(e => e.Address == "Gangnapur,nadia"))
            {
                Console.WriteLine("Phone Number :" + person.PhNo + " Name :" + person.Name + "Age :" + person.Age);
            }
        }

        private static void CheckPhoneNumberPersonPresentOrNot(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => e.PhNo == "6296582055"))
            {
                Console.WriteLine("Name :" + person.Name + "Age :" + person.Age + "Address :" + person.Address);
            }
        }

    }

}
