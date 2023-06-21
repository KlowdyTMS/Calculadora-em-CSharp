namespace ConsoleApp1.models
{
    class PanelCalc
    {
        public void Start()
        {
            var calculadora = new Calculadora();
            bool program = true;
            string[] operations =
{
             "1 - Soma", "2 - Subtração", "3 - Multiplicação", "4 - Divisão", "5 - Encerrar Programa",
        };

            while (program)
            {
                Console.Clear();
                Console.WriteLine($"Valor atual: {calculadora.NumberBase}");
                if (calculadora.NumberBase > 0)
                {
                    Console.WriteLine($"Qual operação deseja realizar?\n{operations[0]}\n{operations[1]}\n{operations[2]}\n{operations[3]}\n{operations[4]}\n6 - Limpar valores");
                }
                else
                {
                    Console.WriteLine($"Qual operação deseja realizar?\n{operations[0]}\n{operations[1]}\n{operations[2]}\n{operations[3]}\n{operations[4]}");
                }
                program = new VerifyOptionCalc().Verify(calculadora);
            }
        }
    }
}