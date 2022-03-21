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
            else
            {
                for (int i = Length + 1; i > 0; i--)
                {
                    _array[i] = _array[i - 1];
                }
                _array[0] = value;
            }
            Length++;
        }

        public void AddToIndex(int index, int value)
        {
            if (Length + 1 >= _array.Length)
            {
                Extention(_array);
            }

            for (int i = Length + 1; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = value;
            Length++;
        }

        public void Pop()
        {
            Length--;
            Constriction(_array);
        }

        public void PopFromStart()
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            Constriction(_array);
        }

        public void PopByIndex(int index)
        {
            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            Constriction(_array);
        }

        public void PopElems(int count)
        {
            Length -= count;
            Constriction(_array);
        }

        private void Constriction(int[] _array)
        {
            int minLength = (int)(_array.Length * 0.6);
            if (Length <= minLength)
            {
                int newLength = (int)(_array.Length * 0.6d + 1);
                int[] newArray = new int[newLength];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                _array = newArray;
            }
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