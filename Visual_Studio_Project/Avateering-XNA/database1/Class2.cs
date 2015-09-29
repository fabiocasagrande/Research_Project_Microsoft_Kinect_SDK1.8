using System;


public class Class2
{

    private static Class2 instance = null;
    public String av1 { get; set; }
    public String av2 { get; set; }
    public String sc { get; set; }

    private Class2()
    {
    }



    public static Class2 stance()
    {


        if (instance == null)
        {

            instance = new Class2();

        }

        return instance;



    }

    public void set(String av1, String av2, String sc)
    {
        this.av1 = av1;
        this.av2 = av2;
        this.sc = sc;
    }




}