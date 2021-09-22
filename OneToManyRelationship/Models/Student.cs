﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToManyRelationship.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CurrentGradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
