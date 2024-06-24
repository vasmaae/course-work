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
        else if (step == 1)
        {
            items.Sort((a, b) => b.ValuePerWeight().CompareTo(a.ValuePerWeight()));
            step++;
            return GetState();
        }
        else if (currentWeight + items[0].Weight <= capacity)
        {
            currentItems.Add(items[0]);
            currentWeight += items[0].Weight;
            currentValue += items[0].Value;
            items.Remove(items[0]);
            step++;
            return GetState();
        }
        else if (!FittingObjects() || currentWeight == capacity || items.Count == 0)
        {
            items.Clear();
            step++;
            return GetState();
        }
        else if (FittingObjects())
        {
            items.Remove(items[0]);
            step++;
            return GetState();
        }

        return GetState();
    }

    public KnapsackState GetState()
    {
        return new KnapsackState(items, capacity, currentItems, currentWeight, currentValue, step);
    }

    private bool FittingObjects()
    {
        foreach (Item item in items)
        {
            if (currentWeight + item.Weight <= capacity)
                return true;
        }
        return false;
    }
}

[Serializable]
public class Item
{
    public int Weight { get; }
    public int Value { get; }

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
