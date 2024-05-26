namespace CourseWork;

/// <summary>
/// Класс-состояние
/// </summary>
[Serializable]
public class KnapsackState
{
    public List<Item> Items { get; }
    public int Capacity { get; }
    public List<Item> CurrentItems { get; }
    public int TotalWeight { get; }
    public int TotalValue { get; }
    public int NumStep { get; }

    public KnapsackState(List<Item> items, int capacity, List<Item> currentItems, int totalWeight, int totalValue, int numStep)
    {
        Items = new List<Item>(items);
        Capacity = capacity;
        CurrentItems = new List<Item>(currentItems);
        TotalWeight = totalWeight;
        TotalValue = totalValue;
        NumStep = numStep;
    }
}
