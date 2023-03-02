namespace CA_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defining values step
            string firstPersonName = "Mahmood ";
            string firstPersonLastName = "Garibov";
            string firstPersonFullName = firstPersonName + " " + firstPersonLastName; //string Concantenation

            int firstPersonAge = 75;
            bool firstPersonIsMarried = true;
            bool hasChild = false;

            Console.WriteLine("Fullname : " + firstPersonFullName);
            Console.WriteLine("Age :" + firstPersonAge);
            Console.Write("Is married :");

            if (firstPersonName == "Eshqin")
            {
                Console.WriteLine("I am mentor");
            }


            if (firstPersonIsMarried)
            { // Scope
                Console.WriteLine("Yes");

                if (hasChild)
                { // Scope
                    Console.WriteLine("+ Ovladi var");
                } // Scope
                else
                {
                    Console.WriteLine("+ Ovladi yoxdur");
                }
            }
            else
            {
                Console.WriteLine("No");
            }

            if (firstPersonName == "Mahmood" && (firstPersonAge == 18 || firstPersonAge == 32))
            {

            }

            if (firstPersonAge == 18 || firstPersonAge == 25 || firstPersonAge == 50)
            {
                Console.WriteLine("Bu sexs kecid dovrundedir");
            }


            if (firstPersonAge <= 25)
            {
                Console.WriteLine("Cavan");
            }
            else if (firstPersonAge > 25 && firstPersonAge <= 60)
            {
                Console.WriteLine("Orta yasli");
            }
            else
            {

                Console.WriteLine("Yasli");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
                Console.WriteLine("Salamlar");
            }
        }
    }
}