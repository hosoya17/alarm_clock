using System.Media;

namespace alarm_clock
{
    public partial class Form1 : Form
    {
        int hour;
        int min;
        int sec;
        int set;
        private System.Threading.Timer uiTimer;
        private bool isAlarmTriggered = false;
        private SoundPlayer player;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            hour = d.Hour;
            min = d.Minute;
            sec = d.Second;
            label1.Text = $"{hour:00}時{min:00}分{sec:00}秒";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int delayInSeconds;
            label6.Visible = true;
            label6.Text = $"設定時刻:{int.Parse(comboBox1.Text):00}時{int.Parse(comboBox2.Text):00}分";
            if (hour < int.Parse(comboBox1.Text))
            {
                set = ((int.Parse(comboBox1.Text) - hour) * 60 * 60) + ((int.Parse(comboBox2.Text) - min) * 60) - sec;
            }
            else if (hour == int.Parse(comboBox1.Text))
            {
                set = ((int.Parse(comboBox1.Text) - hour) * 60 * 60) + ((int.Parse(comboBox2.Text) - min) * 60) - sec;
            }
            else
            {
                set = ((24 - hour + int.Parse(comboBox1.Text)) * 60 * 60) + ((int.Parse(comboBox2.Text) - min) * 60) - sec;
            }
            delayInSeconds = set;
            StartDelayTimer(delayInSeconds);
        }

        private async void StartDelayTimer(int delayInSeconds)
        {
            await Task.Delay(delayInSeconds * 1000);
            ExecuteAfterDelay();
        }
        private void ExecuteAfterDelay()
        {
            label7.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            string soundFilePath = "";//wavファイルのパスを指定してください.。
            player = new SoundPlayer(soundFilePath);
            player.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            player?.Stop();
            player?.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int delayInSeconds = 600;
            label7.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            StartDelayTimer(delayInSeconds);

            player?.Stop();
            player?.Dispose();
        }
    }
}