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

        public void PopElemsFromStart(int count)
        {
            int tmp = count;
            for (int i = 0; i < count; i++)
            {
                for (int j = tmp; j < Length; j++)
                {
                    _array[j] = _array[j + 1];
                }
                tmp--;
            }
            Length -= count;
            Constriction(_array);
        }

        public void PopElemsByIndex(int index, int count)
        {
            if (index > Length)
            {
                throw new Exception("Index must be lower than length");
            }
            if (index + count > Length)
            {
                throw new Exception("Count elements are out of range");
            }
            int tmp = count;
            for (int i = index; i < count; i++)
            {
                for (int j = tmp; j < Length; j++)
                {
                    _array[j] = _array[j + 1];
                }
                tmp--;
            }
            Length -= count;
            Constriction(_array);
        }

        public int Element(int index)
        {
            if (index > Length)
            {
                throw new Exception("Index is out of range");
            }
            return _array[index];
        }

        public int FirstIndexByElem(int elem)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == elem)
                {
                    return i;
                }
            }
            return -1;
        }

        public void ChangeElemByIndex(int index, int value)
        {
            if (index > Length)
            {
                throw new Exception("Index is out of range");
            }
            _array[index] = value;
        }

        public void Reverse()
        {
            int[] newArray = new int[_array.Length];
            int reverseIndex = _array.Length - 1;
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[reverseIndex];
                reverseIndex--;
            }
            _array = newArray;
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