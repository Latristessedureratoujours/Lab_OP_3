using System;

namespace Lab_OP_3
{
    class Text 
    {
        private string _title;
        private int _size;
        private string[][] _content;

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != null)
                {
                    _title = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public string[] SetTextContent
        { set { _content = value; } }

        public int Size
        {
            get { return _size; }
            set
            {
                if (value > 0)
                {
                    _size = value;
                }
                else
                {
                    value = 1;
                }
            }
        }

        public string[] this[int index]
        {
            get
            {
                if (index >= 0 && index < _size)
                    return _content[index];
                else return 0;
            }
            set
            {
                if (index >= 0 && index < _size)
                    _vectArray[index] = value;
            }
        }

        public Text(string title, string [][] content)
        {
            _title = title;
            _content = new string[Size][];

            for (int i = 0; i < Size; i++)
                this[i] = v[i];
        }

    }

    class Paragraph
    {
        private string[][] _paragraph;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Text[] article = new Text[];
        }
    }
}
