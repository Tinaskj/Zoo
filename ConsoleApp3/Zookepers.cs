namespace Zoo_Project
{
    internal class Zookepers
    {
        public string AnimalsToCareFor { get; set; }
        public int YearsOfExperience { get; set; }

        public Zookepers(string animalsToCareFor, int yearsOfExperience)
        {
            AnimalsToCareFor = animalsToCareFor;
            YearsOfExperience = yearsOfExperience;
        }
    }
}