// Model

namespace MVP
{
    class Model
    {
        private int _value = 0;
        
        public int Value { get { return _value; } }

        public void Inc() { _value++; }

        public void Reset() { _value = 0; }

    }
}
