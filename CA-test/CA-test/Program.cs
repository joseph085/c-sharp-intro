namespace CA_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencies = { "USD", "EUR", "RUB" };
            decimal[] currencyRates = { 1.70M, 1.82M, 0.02M };

            string SHOW_CURRENCY_RATES_COMMAND = "/show-currency-rates";
            string FIND_CURRENCY_RATE_BY_CODE = "/find-currency-rate-by-cod";
            string CAULCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE = "/calculate-amount-by-currecy-code";
            string EXIT_COMMAND = "/exit";


            Console.WriteLine("Available commands : ");
            Console.WriteLine(SHOW_CURRENCY_RATES_COMMAND);
            Console.WriteLine(FIND_CURRENCY_RATE_BY_CODE);
            Console.WriteLine(CAULCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE);
            Console.WriteLine(EXIT_COMMAND);

            while (true)
            {
                Console.WriteLine();
                Console.Write("Pls enter command : ");
                string command = Console.ReadLine();
                Console.WriteLine();

                if (command == SHOW_CURRENCY_RATES_COMMAND)
                {
                    ExecuteShowCurrencyRatesCommand(currencyRates, currencies); //METHOD CALL
                }
                else if (command == FIND_CURRENCY_RATE_BY_CODE)
                {
                    ExecuteFindCurrencyRateByCodeCommand(currencyRates, currencies);
                }
                else if (command == CAULCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE)
                {
                    ExecuteCalculateAmountByCurrencyRateByCode(currencyRates, currencies);
                }
                else if (command == EXIT_COMMAND)
                {
                    ExecuteExitCommand();

                    break;
                }
                else
                {
                    Console.WriteLine("Specified command not found");
                }
            }

        }


        /// <summary>
        /// Executes show currency rates functionality
        /// </summary>
        public static void ExecuteShowCurrencyRatesCommand(decimal[] currencyRates, string[] currencies)
        {
            for (int idx = 0; idx < currencyRates.Length; idx++)
            {
                Console.WriteLine($"Currency : {currencies[idx]}, Rate : {currencyRates[idx]}");
            }
        }
        public static void ExecuteFindCurrencyRateByCodeCommand(decimal[] currencyRates, string[] currencies)
        {
            bool isCurrencyExists = false; //flag
            Console.Write("Pls enter code : ");
            string specifiedCode = Console.ReadLine();

            for (int i = 0; i < currencies.Length; i++)
            {
                string currentCode = currencies[i];
                decimal curretCodeRate = currencyRates[i];

                if (currencies[i] == specifiedCode)
                {
                    Console.WriteLine($"Code : {currentCode}, rate : {curretCodeRate} ");
                    isCurrencyExists = true; //update flag
                    break;
                }
            }

            if (!isCurrencyExists) // check flag value
            {
                Console.WriteLine("Specified code not found");
            }
        }
        public static void ExecuteCalculateAmountByCurrencyRateByCode(decimal[] currencyRates, string[] currencies)
        {
            Console.Write("Pls enter amount in AZN : ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Pls enter code : ");
            string specifiedCode = Console.ReadLine();
            bool isCurrencyExists = false;

            for (int i = 0; i < currencies.Length; i++)
            {
                string currentCode = currencies[i];
                decimal curretCodeRate = currencyRates[i];

                if (currentCode == specifiedCode)
                {
                    Console.WriteLine($"Amount in {currentCode} :  {amount / curretCodeRate}");
                    isCurrencyExists = true;
                    break;
                }
            }
            if (!isCurrencyExists)
            {
                Console.WriteLine("Specified code not found");
            }
        }
        public static void ExecuteExitCommand()
        {
            Console.WriteLine("Thanks for using, bye-bye");
        }
    }
}