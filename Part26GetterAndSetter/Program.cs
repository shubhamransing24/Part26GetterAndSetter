using System;

namespace Part26GetterAndSetter
{
    class Students
    {
        private int _rollno;
        private string _name;
        private int _passmark=35;
        public void StudentDetails()
        {
            Console.WriteLine(" Roll no={0} \n Name={1} \n Passmark ={2}", _rollno, _name, _passmark);
        }
        public void SetRollNo(int RollNumber)
        {
            if(RollNumber<0)
            {
                throw new Exception("roll no can not be null");

            }
            this._rollno = RollNumber;
        }

        public int GetRollNo()
        {
            return _rollno;
        }
        public void SetName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Name Can not be empty");
            }
            this._name = name;
        }
        public string GetName()
        {
            return this._name;
        }
        public int GetPassmark()
        {
            return _passmark; ;
        }
    }
  

    class Program
    {


        static void Main(string[] args)
        {
            Students s = new Students();
            s.SetRollNo(33);
            s.GetRollNo();
            s.SetName("Shubham");
            s.GetName();
            s.GetPassmark();
            s.StudentDetails();
        }
    }
}
