namespace Zoo_Project
{
    internal class Animals
    {
        public string TypeOfAnimal { get; set; }
        
        public int NumberOfAnimals { get; set; }
        public string WhatTheyEat { get; set; }

        public string WhenToFeed { get; set; }

        public Animals(string typeOfAnimal, int numberOfAnimals, string whatTheyEat, string whenToFeed)
        {
            TypeOfAnimal = typeOfAnimal;
            NumberOfAnimals = numberOfAnimals;
            WhatTheyEat = whatTheyEat;
            WhenToFeed = whenToFeed;
        }


    }
}