using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "IBM";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2003";
        job1._endYear = "2010";

        Job job2 = new Job();

        job2._company = "Adobe";
        job2._jobTitle = "Web Developer";
        job2._startYear = "2010";
        job2._endYear = "2025";

        Resume myResume = new Resume();
        myResume._name = "Sarah Ranjel";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}