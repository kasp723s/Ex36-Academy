﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Academy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Academy("UCL", "Seebladsgade");

            var s1 = new Student(p, "Jens 1");
            var s2 = new Student(p, "Niels 2");
            var s3 = new Student(p, "Susan 3");

            p.Attach(s1);
            p.Attach(s2);
            p.Attach(s3);

            p.Message = "Så er der julefrokost!";

            p.Detach(s2);

            p.Message = "Så er der fredagsbar!";
        }

    }
}
