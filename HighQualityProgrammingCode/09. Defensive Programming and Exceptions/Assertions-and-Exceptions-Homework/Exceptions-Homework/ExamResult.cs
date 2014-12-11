using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade must be positive!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("Min grade must be positive!");
        }
        if (maxGrade < minGrade)
        {
            throw new ArgumentException("Max grade must be bigger or equal to min grade!");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("Comments cannot be null, you should write some!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
