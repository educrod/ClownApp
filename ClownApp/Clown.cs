using System;
using System.Collections.Generic;
using System.Text;

namespace ClownApp
{
    class Clown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inches tall.");
        }
    }
}
