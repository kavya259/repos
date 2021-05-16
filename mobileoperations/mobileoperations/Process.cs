using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace mobileoperations
    {
    class Process
        {
        ArrayList add = new ArrayList();
        MobileOperator op = new MobileOperator();


        public ArrayList AddMobileOperator()
            {
           
            Console.WriteLine("Enter mobileoperator id");
            op.OperatorId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter mobileoperator Name");
            op.OperatorName = Console.ReadLine();


            Console.WriteLine("Enter mobileoperator Rating");
            op.Rating = Convert.ToDouble(Console.ReadLine());

            add.Add(op.OperatorId);
            add.Add(op.OperatorName);
            add.Add(op.Rating);


            return add;
            }
        ArrayList addPerson = new ArrayList();
        Person person = new Person();


        public ArrayList AddPerson()
            {

            Console.WriteLine("Enter PersonID");
            person.PersonId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Person Name");
            person.PersonName = Console.ReadLine();


            Console.WriteLine("Enter mobileoperatorid used");
            person.MobileOpId = Convert.ToInt32(Console.ReadLine());

            addPerson.Add(person.PersonId);
            addPerson.Add(person.PersonName);
            addPerson.Add(person.MobileOpId);


            return addPerson;
            }
        public void displayMobileOperators()
            {
            Console.WriteLine("========mobile operators=======");
            Console.WriteLine("OperatorId \t OperatorName \t Rating");


            foreach(var item in add)
                {


                Console.WriteLine(op.OperatorId+"\t\t"+op.OperatorName+"\t\t"+op.Rating);

                }


            }







        }
    }
