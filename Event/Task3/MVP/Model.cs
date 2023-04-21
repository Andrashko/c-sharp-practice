// Model

namespace MVP
{
    class Model
    {
        private double _value = 0;

        public double Value { get { return _value; } }
        public double Add(double value)
        {
            _value += value;
            return _value;
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
