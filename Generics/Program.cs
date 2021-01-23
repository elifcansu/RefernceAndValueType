using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            Console.WriteLine(sehirler.Count);
            
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("iSTANBUL");
            sehirler2.Add("iSTANBUL");
            sehirler2.Add("iSTANBUL");
            sehirler2.Add("iSTANBUL");
            Console.WriteLine(sehirler2.Count);
            
        }
    }

    class MyList<T> //Kendi generic lisitemizi oluşturuyoruz.generic class.istediğim tipi verebilirim artık.
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];//İlk çalıştığında 0 elemanlı olarak gelir.
        }
        public void Add(T item)
        {
            _tempArray = _array;//temparray arrayın refini tutuyor. bu sayede verileri kaybetmicez newlediğimizde
            _array = new T[_array.Length + 1]; //yenir bir index ekleniyor.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;//son bir item eklendiğinde uzunluğun bir eksiğine ekleme yaparız.şöyle düşün indexler 0,1,2,3 diye gider ve 4 elemanlıdır. 4-1 yani 3 index 3 e ekleme yapar.
        }

       

        public int Count
        {
            get { return _array.Length; }
            
        }


    }
}
