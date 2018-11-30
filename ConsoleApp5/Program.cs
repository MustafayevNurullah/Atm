using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Comamnd_
    {
        private string Command;
        private DateTime Date;
        public Comamnd_(string Command, DateTime Date)
        {
            this.Command = Command;
            this.Date = Date;
        }
        public string _Command_
        {
            get
            {
                return Command;
            }
        }
        public DateTime Date_
        {
            get
            {
                return Date;
            }
        }


    }
    class Program
    {
        private static int counter;
        private static bool pin_;

        static void Main(string[] args)
        {
            Comamnd_[] Commands = new Comamnd_[0];

            User[] Users = new User[5];
            Users[0] = new User("Nurullah", "Mustafayev", new Card("1111111111111110", "0123", "123", "20/11", 102.12m));
            Users[1] = new User("Tural", "Mustafayev", new Card("1111111111111111", "0124", "124", "20/10", 99.12m));
            Users[2] = new User("Saleh", "Abdullabeyli", new Card("1111111111111112", "0125", "125", "20/09", 203.10m));
            Users[3] = new User("Islam", "Omerov", new Card("1111111111111113", "0126", "126", "20/08", 99.99m));
            Users[4] = new User("Samir", "Osmanov", new Card("1111111111111114", "0127", "127", "20/07", 132.32m));

            int counter = 0;
            int index = 0;
            bool pincontrol = false;

            do
            {

                Console.WriteLine("Enter Pin");
                string pin = Console.ReadLine();
                if (string.IsNullOrEmpty(pin) || string.IsNullOrWhiteSpace(pin))
                {
                    continue;
                }




                for (int i = 0; i < Users.Length; i++)
                {

                    if (pin == Users[i].Card_.Pin_)
                    {
                        index = i;
                        pincontrol = true;
                        counter = 3;
                    }


                }

                if (pincontrol == false)
                {
                    Console.WriteLine("Pin sehfdir");
                    counter++;
                }

            }
            while (counter < 3);
            if (counter == 3 && pincontrol == false)
            {
                System.Environment.Exit(1);
            }

            Console.Clear();
            while (true)
            {




                Console.WriteLine("Xow Gelmisiniz"); Console.Write(Users[index].Name_); Console.Write("   "); Console.WriteLine(Users[index].Surname_);
                Console.WriteLine("1->Balance 2->Nagd Pul 3=>Emeliyyatlar haqqinda melumat  4=>Kartdan karta kocurme");
                string emeliyyat = (Console.ReadLine());
                if (string.IsNullOrEmpty(emeliyyat) || string.IsNullOrWhiteSpace(emeliyyat))
                {
                    continue;
                }

                switch (emeliyyat)
                {
                    case "1":

                        Console.Write("Balance=>"); Console.WriteLine(Users[index].Card_.Balance_);
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        var dateTime = DateTime.Now;
                        Array.Resize(ref Commands, Commands.Length + 1);
                        Commands[Commands.Length - 1] = new Comamnd_("Balance", dateTime);




                        break;

                    case "2":
                        bool asd = false;
                        dateTime = DateTime.Now;
                        Array.Resize(ref Commands, Commands.Length + 1);
                        Commands[Commands.Length - 1] = new Comamnd_("Nagd pul", dateTime);

                        Console.WriteLine("1. 10 AZN");
                        Console.WriteLine("2. 20 AZN");
                        Console.WriteLine("3. 50 AZN");
                        Console.WriteLine("4. 100 AZN");
                        Console.WriteLine("5.Diger mebleg");
                        Console.WriteLine("Enter Mebleg");
                        string Mebleg_ = (Console.ReadLine());
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();

                        switch (Mebleg_)
                        {
                            case "1":
                                try
                                {
                                    if (10 <= Users[index].Card_.Balance_)
                                    {

                                        Users[index].Card_.Balance_ -= 10;



                                    }
                                    else
                                    {
                                        throw new Exception("Balansda istediyiniz mebleg yoxdur.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);


                                }
                                System.Threading.Thread.Sleep(3000);
                                Console.Clear();

                                break;
                            case "2":
                                try
                                {
                                    if (20 <= Users[index].Card_.Balance_)
                                    {

                                        Users[index].Card_.Balance_ -= 20;



                                    }
                                    else
                                    {
                                        throw new Exception("Balansda istediyiniz mebleg yoxdur.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);

                                }
                                System.Threading.Thread.Sleep(3000);
                                Console.Clear();
                                break;

                            case "3":
                                try
                                {
                                    if (50 <= Users[index].Card_.Balance_)
                                    {

                                        Users[index].Card_.Balance_ -= 50;



                                    }
                                    else
                                    {
                                        throw new Exception("Balansda istediyiniz mebleg yoxdur.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);

                                }
                                System.Threading.Thread.Sleep(3000);
                                Console.Clear();
                                break;

                            case "4":
                                try
                                {
                                    if (100 <= Users[index].Card_.Balance_)
                                    {

                                        Users[index].Card_.Balance_ -= 100;



                                    }
                                    else
                                    {
                                        throw new Exception("Balansda istediyiniz mebleg yoxdur.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);

                                }
                                System.Threading.Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            case "5":
                                  Console.WriteLine("Meblegi daxil edin");

                                decimal Mebleg = Convert.ToDecimal(Console.ReadLine());
                                try
                                {
                                    if (Mebleg <= Users[index].Card_.Balance_)
                                    {

                                        Users[index].Card_.Balance_ -= Mebleg;



                                    }
                                    else
                                    {
                                        throw new Exception("Balansda istediyiniz mebleg yoxdur.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);

                                }
                                System.Threading.Thread.Sleep(3000);
                                Console.Clear();
                                break;


                        }
                        break;

                    case "3":
                        for (int i = 0; i < Commands.Length; i++)
                        {
                            Console.Write(Commands[i]._Command_);
                            Console.WriteLine(Commands[i].Date_);
                        }


                        System.Threading.Thread.Sleep(5000);
                        Console.Clear();
                        break;


                    case "4":
                        bool transfer = false;
                        dateTime = DateTime.Now;
                        Array.Resize(ref Commands, Commands.Length + 1);
                        Commands[Commands.Length - 1] = new Comamnd_("Pul transfer", dateTime);
                        Console.WriteLine("Enter Kart Pin");
                        string new_user_pin = Console.ReadLine();
                        for (int i = 0; i < Users.Length; i++)
                        {
                            if (new_user_pin == Users[i].Card_.Pin_)
                            {
                                transfer = true;
                                Console.WriteLine("Enter Mebleg");
                                decimal Mebleg = Convert.ToInt32(Console.ReadLine());
                                try
                                {

                                    if (Mebleg <= Users[i].Card_.Balance_)
                                    {
                                        Users[index].Card_.Balance_ -= Mebleg;
                                        Users[i].Card_.Balance_ += Mebleg;
                                        Console.WriteLine("Emeliyyat ugurla basa catdi");

                                    }
                                    else
                                    {
                                        throw new Exception("Balansinizda kifayet qeder mebleg yoxdur");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);

                                }

                            }
                        }





                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        break;














                }

            }








        }




    }
    class Card
    {
        private string Pan;
        private string Pin;
        private string Cvc;
        private string Date;
        private decimal Balance;

        public Card(string pan, string pin, string cvc, string date, decimal balance)
        {
            Pan = pan;
            Pin = pin;
            Cvc = cvc;
            Date = date;
            Balance = balance;
        }
        public string Pin_
        {
            get
            {



                return Pin;
            }
        }
        public decimal Balance_
        {
            get
            {
                return Balance;
            }
            set
            {
                Balance = value;
            }
        }


    }
    class User
    {
        private string Name;
        private string Surname;
        private Card CreditCard;

        public User(string Name, string Surname, Card CreditCard)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.CreditCard = CreditCard;
        }
        public Card Card_
        {
            get
            {
                return CreditCard;
            }
        }
        public string Name_
        {
            get
            {
                return Name;
            }
        }

        public string Surname_
        {
            get
            {
                return Surname;
            }
        }


    }
    class MyException : Exception
    {
        MyException(string message) : base(message) { }
    }
}
