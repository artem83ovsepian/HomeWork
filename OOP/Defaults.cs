
namespace MyClasses.HomeWork.OOP.Defaults
{
    public static class Default
    {
        public const string FirstName = "Default First Name";
        public const string LastName = "Default Last Name";
        public const string City = "Default City";
        public const int Age = 18;
        public const int CourseDuration = 25;
        public const string CourseName = "Default Course Name";

        public static string GetFullName()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
