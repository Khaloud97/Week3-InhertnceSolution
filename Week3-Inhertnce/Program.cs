namespace Week3_Inhertnce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to the system: ");


            Console.WriteLine("-----EmployeeInfo from method i created -----");
            Employee emp=  new Employee("Muscat","IT",2,4,"Khaloud",26);
            emp.EmployeeInfo();

            Console.WriteLine("\n\n-----override {Humen class + Employee class}-----");

            Console.WriteLine(emp);//will retern  the value from the father (Humen) Inhertnce from it  + Employee class


            Console.WriteLine("\n\n-----override {Humen class + Student class}-----");
            Student std = new Student("Diploma",true,3,4,"Khaloud",26);
            Console.WriteLine(std); // it will print the value from the student class + override from Humen class ==> how? by using ToString method 
           
            
            emp.Move();
            emp.Eat();
            emp.Sleap();
        }
    }
}