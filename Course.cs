namespace SchoolManagement
{
    public class Course
    {
        #region Fields
        private string _title;
        private int _credits;
        #endregion

        #region Properties
        public string Title => _title;
        public int Credits => _credits;
        #endregion

        #region Constructors
        public Course(string title, int credits)
        {
            _title = title;
            _credits = credits;
        }
        #endregion

        #region Methods
        public void Describe() =>
            Console.WriteLine($"{_title} ({_credits} credits)");
        #endregion
    }
}