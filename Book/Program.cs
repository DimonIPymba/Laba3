﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Test", "John Weak", "TestTest");
            book.Show();
        }
    }
}
