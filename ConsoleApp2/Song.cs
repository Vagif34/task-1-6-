using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Song
    {
        private string _name;
        private string _genre;
        private string _singerAgregation;
        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <= 100)
                {
                    _name = value;
                }
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if("Pop"==value || "Rock"==value || "Jazz"==value ||"Techno"==value)
                {
                    _genre = value;
                }
            }
        }
        public  decimal AddRating()
        {
            int [] variable = new int [4];
            decimal avarage = 0;
            int num=0;
            foreach (var item in variable)
            {
                avarage = avarage / 2 + num / 2;
                return avarage;
            }
            
            
        }


    }
}
