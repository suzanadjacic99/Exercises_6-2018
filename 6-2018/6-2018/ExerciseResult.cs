﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _6_2018
{
    class ExerciseResult
    {
        public ExerciseResult(int id, string studentName, string studentIndex, int points)
        {
            Id = id;
            StudentName = studentName;
            StudentIndex = studentIndex;
            Points = points;
        }

        public int Id { get; set; } 
        public string StudentName { get; set; }
        public string StudentIndex { get; set; }
        public int Points { get; set; }
    }
}
