namespace StudentInfoTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Rafael Abdullayev", 35);
            student.GroupNo = 12;
            student.Birthday = DateTime.Now.AddYears(-22);
            student.ShowInfo();


        }
    }

}
