namespace WebApp.Models
{
    public class Students
    {
        public int ID { get; }
        public string First_name { get; }
        public string Last_Name { get; }
        public int Age { get; set; }

        public Students(int _ID, string _First_name, string _Last_Name, int _Age)
        {
            ID = _ID;
            First_name = _First_name;
            Last_Name = _Last_Name;
            Age = _Age;
        }
    }
}