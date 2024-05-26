namespace CourseWork;

/// <summary>
/// Класс-параметр
/// </summary>
public class KnapsackParameters
{
    public List<Item> Items {  get; set; }
    public int Capacity { get; set; }

    public KnapsackParameters(List<Item> items, int capacity)
    {
        Items = items;
        Capacity = capacity;
    }
}
