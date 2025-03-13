using System;

namespace ModUtils
{
    public class ReactiveValue<T>
    {
        private T _value;
        public event Action<T> ValueChanged;

        public T Value
        {
            get => _value;
            set
            {
                if (Equals(_value, value))
                    return;

                _value = value;
                ValueChanged?.Invoke(_value);
            }
        }
    }
}