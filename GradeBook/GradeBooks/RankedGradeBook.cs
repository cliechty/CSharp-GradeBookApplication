using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (this.Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }
            var percentage = averageGrade * .2;
            if (percentage >= 20)
            {
                return 'A';
            }
            if (percentage >= 15)
            {
                return 'B';
            }
            if (percentage >= 10)
            {
                return 'C';
            }
            if (percentage >= 5)
            {
                return 'D';
            }

            return 'F';
        }
    }
}