using System;
using TestReflections;

namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t This is Mood Analyser Problem");
            //MoodAnalyser analyser = new MoodAnalyser("I am in sad Mood");
            //Console.WriteLine(analyser.AnalyserMethod());
            //Console.ReadLine();
            MoodAnalyserFactory.CreateMoodAnalyserObject("TestReflections.MoodAnalyser", "MoodAnalyser");
            Console.ReadLine();
        }
    }
}
