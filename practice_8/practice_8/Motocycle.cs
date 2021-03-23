using System;
using System.Collections.Generic;
using System.Text;

namespace practice_10
{
    internal sealed class Motocycle
    {
        int Id;
        public string producer;
        public string model;
        public double numberKm;
        public DateTime Date;
        public class Engine
        {
            public int size;
            public int power;
        }
    }
}