using AbstractClassesAndInterfaces.Entities.Interfaces;


namespace AbstractClassesAndInterfaces.Entities
{
    public class Developer : Human, IDeveloper
    {
        public List<string> ProgramingLanguagues { get; set; } = new List<string>();
        public int YearsOfExperience { get; set; }

        public Developer(string fullName, int age, long phone, List<string> langages, int experience) : base(fullName, age, phone)
{
            ProgramingLanguagues = langages;
            YearsOfExperience = experience;

}
        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsOfExperience} years of experiene";
        }
        public void Code()
        {
            Console.WriteLine("Strak strak strak");
            Console.WriteLine("Opens Stackoverflow");
            Console.WriteLine("Can not find a solution");
            Console.WriteLine("Cries");
        }
    }
}
