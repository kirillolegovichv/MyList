namespace MyList
{
    public class ListArray
    {
        public int Length { get; private set; }

        private int[] _array;

        public ListArray()
        {
            _array = new int[0];
            Length = 0;
        }

        public void Add(int value)
        {
            if (Length >= _array.Length)
            {
                Extention(_array);
            }

            _array[Length] = value;
            Length++;
        }

        public void AddToStart(int value)
        {
            if (Length + 1 >= _array.Length)
            {
                int newLength = (int)(_array.Length * 1.5d + 1);
                int[] newArray = new int[newLength];
                for (int i = Length + 1; i > 0; i--)
                {
                    newArray[i] = _array[i - 1];
                }
                newArray[0] = value;
                _array = newArray;
            }
            for (int i = Length + 1; i > 0; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[0] = value;
        }

        private void Extention(int[] _array)
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
    }
}