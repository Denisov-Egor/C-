namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить дополнительный код инициализации при загрузке формы
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Устанавливаем максимальное количество выбираемых дат — 14 дней
            monthCalendar1.MaxSelectionCount = 14;

            // Проверяем, выбрана ли одна дата или диапазон
            if (monthCalendar1.SelectionRange.Start == monthCalendar1.SelectionRange.End)
            {
                // Если выбрана одна дата, отображаем её в длинном формате (например, «пятница, 15 мая 2023 года»)
                label1.Text = monthCalendar1.SelectionStart.ToLongDateString();
            }
            else
            {
                // Если выбран диапазон дат, отображаем начало и конец диапазона в формате «дд.мм.гггг»
                label1.Text = $"{monthCalendar1.SelectionRange.Start:dd.MM.yyyy} - {monthCalendar1.SelectionRange.End:dd.MM.yyyy}";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Отображаем выбранную дату и время из DateTimePicker в формате «дд.мм.гггг ЧЧ:ММ:СС»
            label1.Text = dateTimePicker1.Value.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}