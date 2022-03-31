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

        public ListArray(int value)
        {
            _array = new int[10];
            _array[0] = value;
            Length = 1;
        }

        public ListArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                Extention();
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public void Add(int value)
        {
            if (Length >= _array.Length)
            {
                Extention();
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
                Extention();
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
            Constriction();
        }

        public void PopFromStart()
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            Constriction();
        }

        public void PopByIndex(int index)
        {
            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            Constriction();
        }

        public void PopElems(int count)
        {
            Length -= count;
            Constriction();
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
            Constriction();
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
            Constriction();
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
            Extention();
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
            Constriction();
        }

        public override string ToString()
        {
            string str = "";

            for (int i = 0; i < Length; i++)
            {
                str += $"{_array[i]} ";
            }

            return str;
        }

        public override bool Equals(object obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is ListArray))
            {
                isEqual = false;
            }
            else
            {
                ListArray list = (ListArray)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
        }

        private void Constriction()
        {
            int minLength = (int)(_array.Length * 0.6);
            if (Length <= minLength)
            {
                int newLength = (int)(_array.Length * 0.6d + 1);
                int[] newArray = new int[newLength];
                CopyArray(newArray);
            }
        }

        private void Extention()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            CopyArray(newArray);
        }

        private void CopyArray(int[] newArray)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        private void AddList(ListArray list)
        {
            int[] newArray = new int[list.Length + this.Length];
            for (int i = 0; i < this.Length; i++)
            {
                newArray[i] = this[i];
            }
            for (int i = this.Length; i < newArray.Length; i++)
            {
                newArray[i] = list[i - Length];
            }
            Length += list.Length;
            _array = newArray;
        }

        private void AddListByIndex(ListArray list, int index = 0)
        {
            int[] newArray = new int[list.Length + _array.Length];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < list.Length + index; i++)
            {
                newArray[i] = list[i - index];
            }
            for (int i = index + list.Length; i < newArray.Length; i++)
            {
                newArray[i] = _array[i - list.Length];
            }
            Length += list.Length;
            _array = newArray;
        }
    }
}