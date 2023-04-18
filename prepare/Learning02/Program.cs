using System;

class Program
{
    private static Job job1;

    static void Main(string[] args)
    {
        job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "LogMeIn";

    }
}