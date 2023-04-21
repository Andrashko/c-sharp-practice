// Model

namespace MVP
{
    class Model
    {
        private double _value = 0;

        public double Value { get { return _value; } }
        public void Add(double number1, double number2)
        {
            _value = number1 + number2;
        }

        public double Sub(double value)
        {
            _value += value;
            return _value;
        }

        public double Mult(double value)
        {
            _value += value;
            return _value;
        }
    }
}
