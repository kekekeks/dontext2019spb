﻿using System;
using System.Diagnostics;
using Common;

namespace SimpleMono
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PID: "+Process.GetCurrentProcess().Id);
            //SimpleObjectDemo.Demo();
            //WeirdObjectDemo.Demo();
            //CompleteObjectDemo.Demo();
            CallbackDemo.Demo();
        }
    }
}