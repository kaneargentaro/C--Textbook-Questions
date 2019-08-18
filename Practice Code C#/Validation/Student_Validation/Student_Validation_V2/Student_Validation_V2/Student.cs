using System;

namespace Student_Validation_V2
{
    class Student
    {
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
        }

        private string _DOB;
        public string DOB
        {
            get { return _DOB; }
        }

        private string _Number;
        public string Number
        {
            get { return _Number; }
        }
        private int _Grade1;
        public int Grade1
        {
            get { return _Grade1; }
        }
        private int _Grade2;
        public int Grade2
        {
            get { return _Grade2; }
        }
        private int _Grade3;
        public int Grade3
        {
            get { return _Grade3; }
        }
        private int _Grade4;
        public int Grade4
        {
            get { return _Grade4; }
        }



        public Student(string id, string name, string number, int grade1, int grade2, int grade3, int grade4, string dob)
        {
            _ID = id;
            _Name = name;
            _DOB = dob;
            _Number = number;
            _Grade1 = grade1;
            _Grade2 = grade2;
            _Grade3 = grade3;
            _Grade4 = grade4;

        }

        public override string ToString()
        {
            return String.Format("Validated data:\n\tStudent's ID: {0}\n\tStudent's Name: {1}\n\tBirth date: {2}\n\tStudent's Phone Number: {3}\n\tStudent's Grades: {4}%, {5}%, {6}%, {7}%\n"
                , _ID, _Name, _DOB, _Number, _Grade1, _Grade2, _Grade3, _Grade4 );
        }
    }
}
