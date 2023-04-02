using System.ComponentModel.DataAnnotations;

namespace Home_Task_02._04._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //adi daxil edirik
            Console.Write("Enter name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Condition for name:" + CheckName(firstname, 20));


            //soyadi daxil edirik
            Console.Write("Last name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Condition for name:" + CheckName(lastname, 35));


            //ataadi daxil edirik
            Console.Write("Father name:");
            string fathername = Console.ReadLine();
            Console.WriteLine("Condition for name:" + CheckName(fathername, 20));




            //yas araligini daxil edirik
            Console.Write("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Condition for age:" + CheckAge(age));




            //Fin kodu daxil edirik
            Console.WriteLine("Please enter your Pin");
            string fin = Console.ReadLine();
            Console.WriteLine("Condition for age:" + CheckPin(fin));




            //Tel nomresini daxil edirik
            Console.WriteLine("Please enter your phone bumber");
            string word = Console.ReadLine();
            Console.WriteLine("Condition for phone number" + CheckPhoneNumber(word));



            // Pozitionu elave ve maasi elave edirik

            Console.WriteLine("Enter position :");
            string position = Console.ReadLine();
            Console.WriteLine("Condition for position:" + CheckPosition(position));


            Console.WriteLine("Enter salary :");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Condition for position:" + CheckSalary(salary));


        }
        static bool CheckPosition(string position)
        {

            if (position == "HR" || position == "Audit" || position == "Engineer")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static bool CheckSalary(int salary)
        {
            if (salary >= 1500 && salary <= 5000)
            {
                return true;
            }
            else return false;
        }



        static bool CheckWord(string Pin)
        {


            for (int i = 0; i < Pin.Length; i++)
            {
                if ((Pin[i] >= 'A' && Pin[i] <= 'Z') || Pin[i] >= '0' && Pin[i] <= '9')
                {
                    continue;


                }
                else
                {

                    return false;
                    break;
                }

            }

            if (Pin.Length == 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool CheckPhoneNumber(string phoneNumber)
        {

            if (phoneNumber[0] == '+' && phoneNumber[1] == '9' && phoneNumber[2] == '9' && phoneNumber[3] == '4')
            {
                if (phoneNumber.Length == 13)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;

            }
        }




        static bool CheckPin(string Pin)
        {
            if (Pin.Length != 7)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Pin.Length; i++)
                {
                    if ((Pin[i] >= 'A') && (Pin[i] <= 'Z'))
                    {



                    }
                    else
                    {

                        if ((Pin[i] >= '0') && (Pin[i] <= '9'))
                        {



                        }
                        else
                        {
                            return false;


                        }


                    }
                }

                return true;
            }
        }
        static bool CheckAge(int age)
        {

            if (age >= 18 && age <= 65)
            {

                return true;
            }
            else
            {
                return false;
            }
        }


        static bool CheckName(string name, int max)
        {

            bool isCondition1True = IlkHerfBoyukOlmalidir(name);

            if (isCondition1True == false)
            {

                return false;
            }
            else /*if (isCondition1True == true)*/
            {

                bool isCondition2True = checkMinLen(name);

                if (isCondition2True == false)
                {
                    return false;

                }
                else
                {

                    bool isCondition3True = checkMaxLen(name, max);
                    if (isCondition3True)
                    {
                        return true;

                    }
                    else
                    {
                        return false;

                    }


                }
            }

        }

        static bool IlkHerfBoyukOlmalidir(string ad)
        {
            if ((ad[0] >= 'A') && (ad[0] <= 'Z'))
            {

                return true;

            }

            return false;

        }


        static bool checkMinLen(string ad)
        {
            if (ad.Length > 2)
            {

                return true;

            }

            return false;

        }

        static bool checkMaxLen(string ad, int max)
        {
            if (ad.Length < max)
            {

                return true;

            }

            return false;

        }


    }
}