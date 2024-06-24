namespace CourseWork;

/// <summary>
/// Класс-параметр
/// </summary>
public class KnapsackParameters
{
    public List<Item> Items {  get; }
    public int Capacity { get; }

    public KnapsackParameters(List<Item> items, int capacity)
    {
        Items = items;
        Capacity = capacity;
    }
}
