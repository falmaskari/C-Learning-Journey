using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class PhoneBook
    {
        public string[] Names; //Declare properties
        public string[] Numbers;
        public int Size;
        public PhoneBook(int _size) //Create constructor
        {
            this.Size = _size;
            Names = new string[_size];
            Numbers = new string[_size];
        }

        public string this[int index, string Name] //Create indexer that set index and name and get number 
        {
            //Setting values
            set
            {
                if (index > 0 && index < Size)
                {
                    this.Names[index] = Name;
                    this.Numbers[index] = value;
                }
            }
            //Getting value
            get
            {
                for (int i = 0; i < Size; i++)
                {
                    if (Names[i] == Name)
                    {
                        return Numbers[i];
                    }
                }
                return null;
            }
        }
    }
}
