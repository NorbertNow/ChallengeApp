namespace ChallengeApp
{
    public class Employee
    {
        //----------------PROPERTIES-----------------------------------------------------------
        public string Name {get; private set;}
        public string Surname {get; private set;}
        public int Age {get; private set;}
        public List<int> Points {get; private set;}
        public int Result
        {
            get
            {
                return this.Points.Sum();
            }
        }
        //---------------CONSTRUCTORS------------------------------------------------------------
        public Employee(string imie, string nazwisko, int wiek)
        {
            this.Name = imie;
            this.Surname = nazwisko;
            this.Age = wiek;
            this.Points = new List<int>();
        }
        //---------------METHODS------------------------------------------------------------------
        public void AdScore(int number)
        {
            this.Points.Add(number);
        }
    }
}