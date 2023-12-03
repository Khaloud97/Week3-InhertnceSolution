
namespace Week3_Inhertnce
{
     class Employee:Human
    {
         string role;
         string department;
         int working_Hours;
         int wage;

        public Employee()
        {
            
        }
        public Employee(string role, string department, int working_Hours, int wage, string Name, int age):base(Name,age)
        {
           
            this.role = role;
            this.department = department;
            this.working_Hours = working_Hours;
            this.wage = wage;
            

        }

        public void EmployeeInfo()
        {
            Console.WriteLine($"role {this.role} ,department:{this.department} , working_Hours  = {this.working_Hours} ,wage= {this.wage}");
            
        }

        //print override string ToString() with inhertnce value come from Humen
        public override string ToString() 
        {
            // base ==> will return the value (Name + age) come from Humen(الاب)
            return base.ToString() + $" role = {this.role} , from {this.department} department ";
        
        }

        public void CalculateF(int WorkingHours, int Wage)
        {
            int total = WorkingHours * Wage;
            double totalSalary = total * 0.3;


        }

    }

}
