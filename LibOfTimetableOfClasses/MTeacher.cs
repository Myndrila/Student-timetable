﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class MTeacher
    {
        Guid id;
        string surname;
        string name;
        string middleName;
        string academicDegree;
        string academicRank;
        byte sizeOfTeachingExperience;
   
        public Guid Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public string AcademicDegree
        {
            get
            {
                return academicDegree;
            }

            set
            {
                academicDegree = value;
            }
        }

        public string AcademicRank
        {
            get
            {
                return academicRank;
            }

            set
            {
                academicRank = value;
            }
        }

        public byte SizeOfTeachingExperience
        {
            get
            {
                return sizeOfTeachingExperience;
            }

            set
            {
                sizeOfTeachingExperience = value;
            }
        }
    }
}