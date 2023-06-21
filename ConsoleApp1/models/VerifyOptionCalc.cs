namespace ConsoleApp1.models
{
    class VerifyOptionCalc
    {
        private int NumberOperation { get; set; }
        private int[] PossibleNumbers { get; set; } = { 1, 2, 3, 4, 5, 6 };
        public bool Verify(Calculadora calculadora)
        {
            string readline = Console.ReadLine();

            if (!ValidateValue(readline))
            {
                return false;
            }

            if(!int.TryParse(readline, out int NumberOperation))
            {
                return true;
            } else
            {
                if(NumberOperation == 6)
                {
                  calculadora.Clear();
                  Console.Clear();
                  return true;
                } else if(NumberOperation == 5)
                {
                    Console.WriteLine("\nAté a próxima! :)\n");
                    return false;
                }
            }


            string msgValor = "Insira um valor:";
            Console.WriteLine(msgValor);
            var input = Console.ReadLine();
            int.TryParse(input, out int numberValue);
            
            
                switch (NumberOperation)
            {
                case 1:
                    calculadora.Sum(numberValue);
                    return true;
                case 2:
                    Console.WriteLine(msgValor);
                    calculadora.Subtraction(numberValue);
                    return true;
                case 3:
                    Console.WriteLine(msgValor);
                    calculadora.Multiplication(numberValue);
                    return true;
                case 4:
                    Console.WriteLine(msgValor);
                    calculadora.Division(numberValue);
                    return true;
                default:
                    return true;
            }
        }

        private bool ValidateValue(string readline)
        {
            int numberOperation;

            if (!int.TryParse(readline, out numberOperation) || !PossibleNumbers.Contains(numberOperation))
            {
                Console.WriteLine("\nCaractere inválido!");
                Console.WriteLine("\nDeseja continuar? y/n");
                string continuar = Console.ReadLine().ToString();
                if (continuar == "n")
                {
                    return false;
                }

                return true;
            }

            NumberOperation = numberOperation;
            return true;
        }
    }
}
