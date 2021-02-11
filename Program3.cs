using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingThisKeyward
{
    class Movie
    {
        string mName;
        int mTPrice;
        string mHero;
        string mHeroin;

        public void SetMovieInfo(string name, int price, string hero, string heroin)
        {
            mName = name;
            mTPrice = price;
            mHero = hero;
            mHeroin = heroin;

        }
        public void GetMoiveInfo()
        {
            Console.WriteLine(mName);
            Console.WriteLine(mTPrice);
            Console.WriteLine(mHero);
            Console.WriteLine(mHeroin);
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            Movie m = new Movie();
            m.SetMovieInfo("hi", 200, "arjun", "pujaa");
            m.GetMoiveInfo();
        }
    }
}
