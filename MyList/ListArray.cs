namespace MyList
{
    public class ListArray
    {
        public int Length { get; private set; }

        private int[] _array;

        public ListArray()
        {
            _array = new int[10];
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
            int[] newArray = new int[Length];
            int reverseIndex = Length - 1;
            for (int i = 0; i < Length; i++)
            {
                newArray[i] = _array[reverseIndex];
                reverseIndex--;
            }
            _array = newArray;
            Extention(_array);
        }

        public int MaxValue()
        {
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }

            return max;
        }

        public int MinValue()
        {
            int min = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }

            return min;
        }

        public int IndexOfMaxValue()
        {
            int index = 0;
            int max = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] > max)
                {
                    index = i;
                    max = _array[i];
                }
            }

            return index;
        }

        public int IndexOfMinValue()
        {
            int index = 0;
            int min = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] < min)
                {
                    index = i;
                    min = _array[i];
                }
            }

            return index;
        }

        public void AscendingSort()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[j] < _array[i])
                    {
                        int tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        public void DescendingSort()
        {
            for (int i = 1; i < _array.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && _array[j] < _array[j + 1])
                {
                    int tmp = _array[j];
                    _array[j] = _array[j + 1];
                    _array[j + 1] = tmp;
                    j--;
                }
            }
        }

        public int PopElem(int value)
        {
            int tmp;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    tmp = i;
                    for (int j = i; j < _array.Length; j++)
                    {
                        _array[j] = _array[j + 1];
                    }
                    return tmp;
                }
            }
            return -1;
        }

        public void PopAllByValue(int value)
        {
            int count = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;
            Constriction(_array);
        }

        public override string ToString()
        {
            return base.ToString();
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