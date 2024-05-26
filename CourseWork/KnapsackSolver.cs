namespace CourseWork;

/// <summary>
/// Класс-реализатор
/// </summary>
public class KnapsackSolver
{
    private List<Item> items;
    private int capacity;
    private List<Item> currentItems;
    private int currentWeight;
    private int currentValue;
    private int step;

    public KnapsackSolver(KnapsackParameters parameters)
    {
        this.items = new List<Item>(parameters.Items);
        this.capacity = parameters.Capacity;
        this.currentItems = new List<Item>();
        this.currentWeight = 0;
        this.currentValue = 0;
        this.step = 0;
    }

    public KnapsackState Step()
    {
        if (step == 0)
        {
            step++;
            return GetState();
        }

        if (step == 1)
        {
            items.Sort((a, b) => b.ValuePerWeight().CompareTo(a.ValuePerWeight()));
            step++;
            return GetState();
        }

        if (currentWeight + items[0].Weight > capacity || currentWeight == capacity || items.Count == 0)
        {
            items.Clear();
            step++;
            return GetState();
        }

        if (currentWeight + items[0].Weight <= capacity)
        {
            currentItems.Add(items[0]);
            currentWeight += items[0].Weight;
            currentValue += items[0].Value;
            items.Remove(items[0]);
        }

        step++;
        return GetState();
    }

    public KnapsackState GetState()
    {
        return new KnapsackState(items, capacity, currentItems, currentWeight, currentValue, step);
    }

    public void RestoreState(KnapsackState state)
    {
        currentItems = new List<Item>(state.Items);
        currentWeight = state.TotalWeight;
        currentValue = state.TotalValue;
    }
}

[Serializable]
public class Item
{
    public int Weight { get; set; }
    public int Value { get; set; }

    public Item(int weight, int value)
    {
        Weight = weight;
        Value = value;
    }

    public double ValuePerWeight()
    {
        return (double)Value / Weight;
    }
}
