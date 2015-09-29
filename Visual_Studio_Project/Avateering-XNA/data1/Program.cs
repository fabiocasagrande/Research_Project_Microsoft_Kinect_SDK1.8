using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


     class Program
    {
       
        public String Av1;
        public String Av2;
        public String Scen;

        public Program()
        {
            Av1 = "";
            Av2 = "";
            Scen = "";

        }

        public void setAv1(String n)
        {
            Av1 = n;
        }
        public void setAv2(String n)
        {
            Av2 = n;
        }
        public void setScen(String n)
        {
            Scen = n;
        }

        public String getResult()
        {
            return Av1 + " " + Av2 + " " + Scen;
        }

        static void Main(){

        }

    }

