namespace CourseWork;

/// <summary>
/// Класс-визуализатор
/// </summary>
public class KnapsackVisualizer
{
    private PictureBox pictureBox;

    public KnapsackVisualizer(PictureBox pictureBox)
    {
        this.pictureBox = pictureBox;
    }

    public void Visualize(KnapsackState state)
    {
        Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
        if (state != null)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                DrawState(g, state);
            }
        }
        pictureBox.Image = bitmap;
    }

    private void DrawState(Graphics g, KnapsackState state)
    {
        int startXItems = 6;
        int startXCurrentItems = 190;
        int startY = 22;

        int itemWidth = 120;
        int itemHeight = 15;
        int margin = 5;

        int countItems = 0;
        int countCurrentItems = 0;

        foreach (Item item in state.Items)
        {
            Rectangle rectangle = new(startXItems, startY + countItems * (itemHeight + margin), itemWidth, itemHeight);
            g.DrawRectangle(Pens.Black, rectangle);
            g.DrawString($"В:{item.Weight}, С:{item.Value}, С/В:{item.ValuePerWeight():F2}", 
                SystemFonts.DefaultFont, Brushes.Black, startXItems, startY + countItems * (itemHeight + margin));
            countItems++;
        }

        foreach (Item item in state.CurrentItems)
        {
            Rectangle rectangle = new(startXCurrentItems, startY + countCurrentItems * (itemHeight + margin), itemWidth, itemHeight);
            g.DrawRectangle(Pens.Black, rectangle);
            g.DrawString($"В:{item.Weight}, С:{item.Value}, С/В:{item.ValuePerWeight():F2}",
                SystemFonts.DefaultFont, Brushes.Black, startXCurrentItems, startY + countCurrentItems * (itemHeight + margin));
            countCurrentItems++;
        }
    }
}
