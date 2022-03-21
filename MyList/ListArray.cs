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
                int newLength = (int)(_array.Length * 1.5d + 1);
                int[] newArray = new int[newLength];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                _array = newArray;
            }

            _array[Length] = value;
            Length++;
        }
    }
}