using System;
using System.Collections;

namespace collection11
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            bool acceptFlag = false;

            while (!acceptFlag)
            {
                Console.WriteLine("Enter some integer");
                int i = Convert.ToInt32(Console.ReadLine());
                arrayList.Add(i);                               //adding element entered into arraylist
                Console.WriteLine("Do you want to continue ? Y/N ");
                char accept = Convert.ToChar(Console.ReadLine().ToUpper());
                if (accept == 'Y')
                {
                    acceptFlag = true;
                }
                else
                {
                    acceptFlag = false;

                }



            }
            int count = arrayList.Count+1;
            Console.WriteLine("Number of integers in arraylist : {0}", count);//counting number of values
            int sum = 0;
            foreach (int number in arrayList)
            {
                sum = sum + number;

            }
            int average = sum / count;
            Console.WriteLine("Average of all integers in arraylist : {0}", average);
            int middlePosition = count / 2;
            arrayList.Insert(middlePosition, average);                            //inserting avg in mid position


            Console.WriteLine(" integers in arraylist after inserting in the mid position ");

            foreach (var number in arrayList)
            {
                Console.WriteLine(number+" ,");       //printing all numbers in arraylist

            }

            arrayList.Remove(arrayList[1]);
            Console.WriteLine("list after 2nd value removed");

            foreach (var number in arrayList)
            {
                Console.WriteLine(number+", ");       //printing all numbers in arraylist after removing element at 2nd position


            }
            int avgPosition=0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i].Equals(average))
                {
                    avgPosition = i;
                }
                else if (i ==( arrayList.Count )- 1)
                {
                    Console.WriteLine("average value not found");
                
                }
            
            }
            arrayList.RemoveAt(avgPosition);
            Console.WriteLine("list after average value removed");

            foreach (var number in arrayList)
            {
                Console.WriteLine(number+", ");       //printing all numbers in arraylist after removing averaged element.


            }

            //difference between Remove and Removeat is
          //  Remove removes the element by providing element
          //RemoveAt removes by taking index of that element


        }
    }
}

