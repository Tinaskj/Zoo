namespace Zoo_Project
{
    internal class Enclosures
    {
        public string TypeOf { get; set; }
        public int SizeInKvm { get; set; }
        public bool IsUsed { get; set; }

        public Enclosures(string typeOf, int sizeInKvm, bool isUsed)
        {
            TypeOf = typeOf;
            SizeInKvm = sizeInKvm;
            IsUsed = isUsed;
        }
    }
}