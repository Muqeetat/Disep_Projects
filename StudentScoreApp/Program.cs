using System;
using System.Collections.Generic;
using StudentScoreApp;

class Program
{
    static void Main()
    {
        string studentName = StudentScore.GetStudentName();
        int scoreCount = StudentScore.GetScoreCount();
        List<int> scores = StudentScore.GetScores(scoreCount);

        StudentScore.PrintScoreTable(studentName, scores);
    }


    
}