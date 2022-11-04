namespace Zoo_Project
{
    public class Employees
    {
        public int Id { get; set; }
        public string Position { get; set; }
        
        public double Salary { get; set; }

        public Employees(int id, string position, double salary)
        {
            Id = id;
            Position = position;
            Salary = salary;    
        }
    }
}