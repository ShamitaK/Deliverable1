using System;

namespace Deliverable1
{
    class vacationDecisions
    {
        public static void Main(string[] args)
        {
            {
                string vacationType;
                int groupSize;
                string result = "Since you are a group of ";

                Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous?  ");
                vacationType = Console.ReadLine();
                // Console.WriteLine(vacationType);

                Console.Write("How many are in your group? ");
                groupSize = int.Parse(Console.ReadLine());
                // Console.WriteLine(groupSize);

                result += groupSize + " going on a " + vacationType + " vacation, you should take a ";
                if(groupSize > 0 && groupSize <= 2){
                    result += "first class flight " ;
                } else if(groupSize > 2 && groupSize <= 5) {
                    result += "helicopter ";
                } else if(groupSize >= 6) {
                    result += "charter flight ";
                }

                if (vacationType.Equals("musical")){
                    result += "to New Orleans.";
                } else if (vacationType.Equals("tropical")){
                    result += "to a beach vacation in Mexico.";
                } else if (vacationType.Equals("adventurous")){
                    result += "to whitewater raft the Grand Canyon.";
                }

                Console.WriteLine(result);
            }
        }
    }
}
