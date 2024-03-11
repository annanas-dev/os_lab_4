﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_4_OS
{
    public class BackgroundWorker
    {
        public void Execute()
        {
            new Thread(() =>
            {
                while (true) 
                {
                    Console.WriteLine("Фоновый поток работает...");
                    Thread.Sleep(1000);
                }
            })
            { IsBackground = true }.Start();
        }
    }
}
