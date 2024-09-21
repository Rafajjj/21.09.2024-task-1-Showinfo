

namespace StudentInfoTask1
{
    public class Student
    {
        //fields
        public string FullName;
        public DateTime Birthday;
        public int GroupNo;
        public int Point;

        public Student(string fullName, int point)
        {
            FullName = fullName;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {FullName}  Birthday: {Birthday} GroupNo: {GroupNo} Point: {Point}");

        }
    }

}
