
namespace Week3_Inhertnce
{

    // if i want to inhertnce from Creatures  and use the interface of them  and use the method insdit 
    //1) I will inhertnce  (Creatures class ) ,  then implement method which inside (IMove)interface in side this (class Human) 
    abstract class Human:Creatures ,IMove
    {

        public void Move()
        {
            Console.WriteLine("I can move");
        }
        public void Sleap()
        {
            Console.WriteLine(" I can sleap ");
        }
        public void Eat()
        {
            Console.WriteLine(" I can Eat ");
        }

       public int Id;
       public string Name;
       public bool Has_job;
       public int age;
       public bool Is_Married;

        public Human()
        {
            
        }
        public Human(int Id, string Name, bool Has_job, int age, bool Is_Married)
        {
            this.Id = Id;
            this.Name = Name;
            this.Has_job = Has_job;
            this.age = age;
            this.Is_Married = Is_Married;


         }
        public Human( string Name, int age)
        {
           
            this.Name = Name;
            this.age = age;
            
        }

        public override string ToString()
        {
            return $"My name is {Name} .I am {age} years old ";
        }








    }


    

}
