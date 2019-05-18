namespace Data.Models
{
    public class ModelDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public EnumDepartmentsType.DepartmentType DepartmentType { get; set; }
        public int? SuperiorDepartmentId { get; set; }
        public int? ManagerEmployeeId { get; set; }

        public override string ToString()
        {

            return $"{Name} {Code}";
        }
    }
}
