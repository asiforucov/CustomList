using System;

namespace AList
{
    public class CustomList<T>
    {
        private int _length = 0;
        private T[] _base;

        #region indexer
        public T this[int index] { get { return _base[index]; } set { _base[index] = value; } }
        #endregion

        #region constructur
        public CustomList()
        {
            _base = new T[1];
        }
        public CustomList(int length)
        {
            _base = new T[length];
        }
        #endregion

        #region list copy
        /// <summary>
        /// list copy eden
        /// </summary>
        /// <param name="_new"></param>
        /// <param name="_base"></param>
        /// <returns></returns>
        private T[] Copy(T[] _new, T[] _base)
        {
            for (int i = 0; i < _base.Length; i++)
            {
                _new[i] = _base[i];
            }
            return _new;
        }
        #endregion

        #region list generator
        /// <summary>
        /// daxili list yaradan
        /// </summary>
        private void ListGenerator()
        {
            T[] _new = new T[_base.Length * 2];
            _base = Copy(_new, _base);

        }
        #endregion

        #region IndexOf
        /// <summary>
        /// elementin hansi index de oldugunu gosterir yoxdusa -1 gosterir
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private int IndexOf(T item)
        {
            for (int i = 0; i < _base.Length; i++)
            {
                if (item.Equals(_base[i]) )
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Reverse
        /// <summary>
        /// listi ters cevirir
        /// </summary>
        public void Reverse()
        {
            T[] Reverse = new T[_length];
            for (int i = _length - 1; i >= 0; i--)
            {
                Reverse[(_length - 1) - i] = _base[i];
            }
            _base = Reverse;
        }
        #endregion

        #region Length
        /// <summary>
        /// listin uzunlugunu verir
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return _length;
        }
        #endregion

        #region remove
        /// <summary>
        /// elementi listden silir
        /// </summary>
        /// <param name="item"></param>
        public int Remove(T item)
        {
            if (IndexOfItem(item) < 0)
            {
                return -1;
            }

            RemoveAt(IndexOfItem(item));
            _length --;
            if (IndexOfItem(item) > 0)
            {
                Remove(item);
            }

            return -1;

        }
        /// <summary>
        /// elementin hansi indexde yerlesdiyin gosterir
        /// </summary>
        /// <param name="item"></param>
        /// <returns> int tipinde indeksi return edir</returns>
        private int IndexOfItem(T item)
        {
            int IndexOfItem = -1;
            for (int i = 0; i < _length; i++)
            {
                if (item.Equals(_base[i]))
                {
                    IndexOfItem = i;
                    return IndexOfItem;
                }
            }

            return IndexOfItem;
        }
        /// <summary>
        /// gosterilen indexde olan elementi silir
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            for (int i = index; i < _length; i++)
            {
                _base[i] = _base[i + 1];
            }
        }
        #endregion

        #region clear
        /// <summary>
        /// listi clear eliyir
        /// </summary>
        public void Clear()
        {
            _base = _base = new T[0];
        }
        #endregion

        #region add
        /// <summary>
        /// liste add edir
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (_length == _base.Length)
            {
                ListGenerator();
            }
            _base[_length] = item;
            _length++;
        }
        #endregion

        #region addrange
        public void AddRange(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Add(arr[i]);
            }
        }
        #endregion
    }
}
