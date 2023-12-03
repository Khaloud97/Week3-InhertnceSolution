
namespace Week3_Inhertnce
{
    class Student :Human
    {
       public string Qualification;
       public bool intern;
       public int TotalGread;
       public int Student_hours;
    
    public Student(string Qualification, bool intern, int TotalGread, int Student_hours , string Name, int age) : base(Name, age)
        {

        this.Qualification = Qualification;
        this.intern = intern;
        this.TotalGread = TotalGread;
        this.Student_hours = Student_hours;

    }
        public override string ToString()
        {
            // base ==> will return the value (Name + age) come from Humen(الاب)
            return base.ToString() + $" ,your Qualification : {this.Qualification}";
        }


    }
}
