// Model

namespace MVP
{
    class Model
    {
        private double _value = 0;
        public double Add(double value)
        {
            _value += value;
            return _value;
        }

    }
}
