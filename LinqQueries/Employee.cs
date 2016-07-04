namespace LinqQueries
{
    public class Employee
    {
        int _id;

        public int Id {

            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name { get; set; }

        public int DepartmentId { get; set; }
    }
}