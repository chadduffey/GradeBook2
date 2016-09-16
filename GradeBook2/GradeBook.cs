using GradeBook2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GradeBook
{
    public class GradeBook
    {

        List<float> grades;
        private String _name;

        public event NameChangedDelegate NameChanged;

        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public void WriteGrade(TextWriter destination)
        {
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i -1]);
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }

                    _name = value;
                }
            }
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

    }
}
