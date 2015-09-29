using System;

public class Class1
{
	

        public String Av1;
        public String Av2;
        public String Scen;

        public Class1()
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

    
}
