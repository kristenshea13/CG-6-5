using System;

namespace CG_6_5_Zodiac_Good
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your Zodiac sign?");
            Console.WriteLine(); //line break for ease of reading

            //prompt for date of birth
            Console.Write("Please enter your date of birth (MM/DD/YYYY): ");
            
            //declare as datetime and name variable, and then convert from string to datetime using parse
            DateTime userBirthdate = DateTime.Parse(Console.ReadLine());

            //determine day of week birthdate is using the ToString method and print it to console
            Console.WriteLine("You were born on a {0}.", userBirthdate.ToString("dddd"));

            DateTime currentdate = DateTime.Now;
            //assign variable name and type to current date for use in if/else if statements below

            DateTime nextBDay = new DateTime(currentdate.Year, userBirthdate.Month, userBirthdate.Day);
            //create new datetime variable for birthday in current year to use in if/else if statements below



            //if day of year of your birthday is greater than or equal to current day of year,
            //the day of week will be determined by using current year
            //print day of the week to console using ToString
            if (userBirthdate.DayOfYear >= currentdate.DayOfYear)
            {
                Console.WriteLine("Your next birthday will be on a {0}.", nextBDay.ToString("dddd"));
            }


            //if day of year of your birthday has happened already this year, add 1 year to date to get correct day
            //print to console using ToString
            else if (userBirthdate.DayOfYear < currentdate.DayOfYear)
            {
                DateTime nextBDdayofwk = nextBDay.AddYears(1);
                Console.WriteLine("Your next birthday will be on a {0}", nextBDdayofwk.ToString("dddd"));
            }


            //had to declare the birthMonth and birthDay variables to use in my method below
            //used .Month to extract month as an integer
            //used .Day to extract day as an integer
            var birthMonth = userBirthdate.Month;
            
            var birthDay = userBirthdate.Day;


            //print zodiac sign and fortune from method below
            Console.WriteLine(Zodiac(birthMonth, birthDay));



            Console.ReadLine();



        }


        /// <summary>
        /// logic to determine zodiac sign using birth day and month
        /// </summary>
        /// <param name="birthMonth"></param>
        /// <param name="birthDay"></param>
        /// <returns>zodiac sign and fortune</returns>
        private static string Zodiac(int birthMonth, int birthDay)
        {

            // created a method using if/else if/else statements to determine zodiac sign by comparing
            //birth day and month of user to astrology dates to choose the correct one.
            //return the zodiac sign and fake fortune to print on the console above
            if ((birthMonth == 3 && birthDay >= 21) || (birthMonth == 4 && birthDay <= 19))
                return "Your Zodiac Sign is Aries. \n Fortune: You will trip on your own shoelace tomorrow at Noon.";

            else if ((birthMonth == 4 && birthDay >= 20) || (birthMonth == 5 && birthDay <= 20))
                return "Your Zodiac Sign is Taurus. \n Fortune: You will find a worm in the next apple you eat";

            else if ((birthMonth == 5 && birthDay >= 21) || (birthMonth == 6 && birthDay <= 20))
                return "Your Zodiac Sign is Gemini. \n Fortune: You will lose $137.56 to your best friend in a Poker game this month.";

            else if ((birthMonth == 6 && birthDay >= 21) || (birthMonth == 7 && birthDay <= 22))
                return "Your Zodiac Sign is Cancer. \n Fortune: You will pick up the most perfect watermelon " +
                    "you have ever seen at the supermarket. \n" +
                    "It will slip out of your hand while you are putting it into your cart, crack, " +
                    "and the juice of \nthe most perfect watermelon will drip all over the floor.";

            else if ((birthMonth == 7 && birthDay >= 23) || (birthMonth == 8 && birthDay <= 22))
                return "Your Zodiac Sign is Leo. \n Fortune: You will take a walk, meet a squirrel, and you and the squirrel will have a lovely conversation";

            else if ((birthMonth == 8 && birthDay >= 23) || (birthMonth == 9 && birthDay <= 22))
                return "Your Zodiac Sign is Virgo. \n " +
                    "Fortune: You are practically perfect in every single way. You're basically Mary Poppins without an umbrella.";

            else if ((birthMonth == 9 && birthDay >= 23) || (birthMonth == 10 && birthDay <= 22))
                return "Your Zodiac Sign is Libra. \n " +
                    "Fortune: You will accidentally leave the lights on at home some night this week, a lightbulb will burn out, \n" +
                    "and you won't notice until you come home late that night and try to turn on the light.";

            else if ((birthMonth == 10 && birthDay >= 23) || (birthMonth == 11 && birthDay <= 21))
                return "You are a Scorpio. \n Fortune: Your cat dislikes you. " +
                    "He puts up with you because you feed him, \n but really he just thinks you're annoying.";

            else if ((birthMonth == 11 && birthDay >= 22) || (birthMonth == 12 && birthDay <= 21))
                return "You are a Sagittarius. \n Fortune: Good luck tomorrow! You'll need it!";

            else if ((birthMonth == 12 && birthDay >= 22) || (birthMonth == 1 && birthDay <= 19))
                return "You are a Capricorn. \n Fortune: Something is going to happen to you today. " +
                    "Just play along with it, even if it sounds ridiculous.";

            else if ((birthMonth == 1 && birthDay >= 20) || (birthMonth == 2 && birthDay <= 18))
                return "You are an Aquarius. \n Fortune: You will find a pool and take a swim. Go now. Do it. " +
                    "Your fortune said you had to. \n It doesn't matter if you forgot your suit, just jump in!";

            else if ((birthMonth == 2 && birthDay >= 19) || (birthMonth == 3 && birthDay <= 20))
                return "You are a Pisces. \n " +
                    "Fortune: You have been slowly turning into a fish for the past year. " +
                    "People might start dangling fishing hooks. \n Be careful and trust no hungry human.";

            else
                return "You have no sign and no fortune. Do you really even exist?";
 
           
        }














}
}
