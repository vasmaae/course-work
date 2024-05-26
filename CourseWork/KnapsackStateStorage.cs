using System.Runtime.Serialization.Formatters.Binary;

namespace CourseWork;

/// <summary>
/// Класс-хранилище
/// </summary>
[Serializable]
public class KnapsackStateStorage
{
    private List<KnapsackState> states;
    private int currentIndex;

    public int CountOfStates => states.Count;

    public KnapsackStateStorage()
    {
        states = new List<KnapsackState>();
        currentIndex = 0;
    }

    public void AddState(KnapsackState state)
    {
        states.Add(state);
    }

    public KnapsackState GetNextState()
    {
        if (currentIndex < CountOfStates - 1)
        {
            return states[++currentIndex];
        }
        return states[currentIndex];
    }

    public KnapsackState GetPreviousState()
    {
        if (currentIndex > 0)
        {
            return states[--currentIndex];
        }
        return states[currentIndex];
    }

    public KnapsackState? Reset()
    {
        if (states.Count > 0)
        {
            currentIndex = 0;
            return states[currentIndex];
        }
        return null;
    }

    public void SaveToFile(string filePath)
    {
        using (FileStream fs = new(filePath, FileMode.Create))
        {
            #pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new();
            formatter.Serialize(fs, this);
            #pragma warning restore SYSLIB0011
        }
    }

    public void LoadFromFile(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            #pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new();
            states = ((KnapsackStateStorage)formatter.Deserialize(fs)).states;
            #pragma warning restore SYSLIB0011
        }
    }
}
