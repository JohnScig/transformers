namespace Data.Repositories
{
    // Trieda zrejme by mala byť statická, ale vo všobecnosti je celá zbytočná.
    public class MainRepository
    {
        public static EmployeeRepository EmployeeRepository = new EmployeeRepository();
        public static StructureRepository StructureRepository = new StructureRepository();
        public static TestConnectionRepository TestConnectionRepository = new TestConnectionRepository();
    }
}