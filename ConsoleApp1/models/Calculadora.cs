namespace ConsoleApp1.models
{
    class Calculadora
    {
        public int NumberBase { get; private set; } = 0;

        public void Sum(int numberReference)
        {
            this.NumberBase = this.NumberBase + numberReference;
        }
        public void Subtraction(int numberReference)
        {
            this.NumberBase = this.NumberBase - numberReference;
        }
        public void Multiplication(int numberReference)
        {
            NumberBase = NumberBase * numberReference;
        }
        public void Division(int numberReference)
        {
            this.NumberBase = this.NumberBase / numberReference;
        }
        public void Clear()
        {
            NumberBase = 0;
        }
    }
}
