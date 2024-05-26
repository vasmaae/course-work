namespace CourseWork;

/// <summary>
/// Форма ввода
/// </summary>
public partial class InputForm : Form
{
    private List<Item> items;
    public KnapsackParameters? Parameters { get; private set; }

    public event EventHandler? ParametersSubmitted;

    public InputForm()
    {
        InitializeComponent();
        items = new List<Item>();
    }

    private void ButtonAddItem_Click(object sender, EventArgs e)
    {
        int weight = (int)numericUpDownWeight.Value;
        int value = (int)numericUpDownValue.Value;

        items.Add(new Item(weight, value));
        listBoxItems.Items.Add($"Вес: {weight}, Стоимость: {value}");
    }

    private void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (items.Count == 0)
        {
            MessageBox.Show("Не введены предметы");
            return;
        }

        int capacity = (int)numericUpDownCapacity.Value;
        Parameters = new KnapsackParameters(items, capacity);
        ParametersSubmitted?.Invoke(this, EventArgs.Empty);
        this.Close();
    }

    private void ButtonReset_Click(object sender, EventArgs e)
    {
        items.Clear();
        listBoxItems.Items.Clear();
        numericUpDownWeight.Value = 5;
        numericUpDownValue.Value = 10;
        numericUpDownCapacity.Value = 10;
    }
}
