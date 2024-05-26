namespace CourseWork;

/// <summary>
/// Класс-управленец
/// </summary>
public class KnapsackManager
{
    private KnapsackSolver solver;
    public KnapsackStateStorage Storage { get; }

    public KnapsackManager(KnapsackParameters parameters)
    {
        this.solver = new KnapsackSolver(parameters);
        this.Storage = new KnapsackStateStorage();
    }

    public void Run()
    {
        Storage.Reset();

        while (solver.GetState().Items.Count != 0)
        {
            Storage.AddState(solver.Step());
        }
    }
}
