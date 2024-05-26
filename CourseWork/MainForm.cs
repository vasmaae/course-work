namespace CourseWork;

/// <summary>
/// Главная форма
/// </summary>
public partial class MainForm : Form
{
    private KnapsackManager? manager;
    private KnapsackVisualizer visualizer;

    public MainForm()
    {
        InitializeComponent();
        visualizer = new KnapsackVisualizer(pictureBox);
    }

    private void ButtonRun_Click(object sender, EventArgs e)
    {
        ShowInputForm();
    }

    private void ShowInputForm()
    {
        InputForm inputForm = new();
        inputForm.ParametersSubmitted += InputForm_ParametersSubmitted;
        inputForm.ShowDialog();
    }

    private void InputForm_ParametersSubmitted(object? sender, EventArgs e)
    {
        var inputForm = sender as InputForm;
        if (inputForm != null && inputForm.Parameters != null)
        {
            manager = new KnapsackManager(inputForm.Parameters);
            manager.Run();
            KnapsackState? state = manager.Storage.Reset();
            if (state != null)
            {
                panelSteps.Enabled = true;
                groupBoxVisualization.Enabled = true;
                groupBoxStatus.Enabled = true;
                groupBoxSteps.Enabled = true;
                groupBoxKnapsack.Enabled = true;
                UpdateVisualization(state);
            }
        }
    }

    private void UpdateVisualization(KnapsackState state)
    {
        visualizer.Visualize(state);

        labelTotalSteps.Text = $"Количество шагов:\n{manager.Storage.CountOfStates}";
        labelCurrentStep.Text = $"Текущий шаг:\n{state.NumStep}";

        labelCapacity.Text = $"Вместимость:\n{state.Capacity}";
        labelCurrentWeight.Text = $"Текущий вес:\n{state.TotalWeight}";
        labelCurrentValue.Text = $"Текущая стоимость:\n{state.TotalValue}";

        if (state.NumStep == manager.Storage.CountOfStates)
        {
            labelStatus.Text = $"Статус:\nРюкзак заполнен";
            return;
        }
        switch (state.NumStep)
        {
            case 1:
                labelStatus.Text = $"Статус:\nПредметы выбраны";
                break;
            case 2:
                labelStatus.Text = $"Статус:\nПредметы\nотсортированы";
                break;
            default:
                labelStatus.Text = $"Статус:\nРюкзак заполняется";
                break;
        }
    }

    private void ButtonNext_Click(object sender, EventArgs e)
    {
        if (manager == null)
        {
            return;
        }

        KnapsackState state = manager.Storage.GetNextState();
        UpdateVisualization(state);

        if (state.NumStep == manager.Storage.CountOfStates && checkBoxShowMessageBox.Checked)
        {
            MessageBox.Show("Рюкзак заполнен", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void ButtonPrevious_Click(object sender, EventArgs e)
    {
        if (manager == null)
        {
            return;
        }

        KnapsackState state = manager.Storage.GetPreviousState();
        UpdateVisualization(state);
    }

    private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        InformationForm infoForm = new InformationForm();
        infoForm.ShowDialog();
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (manager == null)
        {
            MessageBox.Show("Данные для сохранения отсутствуют", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                manager.Storage.SaveToFile(saveFileDialog.FileName);
                MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                KnapsackParameters parameters = new KnapsackParameters(new List<Item>(){ new Item(1, 1) }, 1);
                manager = new KnapsackManager(parameters);
                manager.Storage.LoadFromFile(openFileDialog.FileName);
                panelSteps.Enabled = true;
                groupBoxVisualization.Enabled = true;
                groupBoxStatus.Enabled = true;
                groupBoxSteps.Enabled = true;
                groupBoxKnapsack.Enabled = true;
                UpdateVisualization(manager.Storage.Reset());
                MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
