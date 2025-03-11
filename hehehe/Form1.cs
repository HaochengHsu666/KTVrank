namespace hehehe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string[] song = new string[] { "琴傷", "烏梅子醬", "on my way", "突然好想你", "好不容易", "孤勇者", "甩蔥歌" };
        string[] singer = new string[] { "周杰倫", "李榮浩", "Alen Walker", "五月天", "告五人", "陳奕迅", "初音未來" };
        int[] no = new int[] { 1, 2, 3, 4, 5, 6, 7 };


        private void button2_Click(object sender, EventArgs e)
        {
            string[] song2 = new string[song.Length];
            song.CopyTo(song2, 0);
            Array.Sort(song, no);
            Array.Sort(song2, singer);
            for (int i = 0; i < no.Length; i++)
            {

                textBox1.Text += $"{no[i]}\t{singer[i]}\t\t{song[i]}" + Environment.NewLine;
                //textBox1.Text = textBox1+$"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < no.Length; i++)
            {
                int[] no2 = new int[no.Length];
                no.CopyTo(no2, 0);
                Array.Sort(no, singer);
                Array.Sort(no2, song);
                textBox1.Text += $"{no[i]}\t{singer[i]}\t\t{song[i]}" + Environment.NewLine;
                //textBox1.Text = textBox1+$"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] singer2 = new string[singer.Length];
            singer.CopyTo(singer2, 0);
            Array.Sort(singer, song);
            Array.Sort(singer2, no);
            for (int i = 0; i < singer.Length; i++)
            {
                textBox1.Text += $"{no[i]}\t{singer[i]}\t\t{song[i]}" + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string search = textBox2.Text;
            string msg = $"找不到{search}";
            int index = Array.IndexOf(singer, search);
            //當index找不到時 為-1
            if (index >= 0)
            {
                msg = "排名\t歌手\t歌曲" + Environment.NewLine;
                while (index >= 0) //只要index>=0就一直執行此迴圈
                {
                    msg += $"{no[index]}\t{singer[index]}\t{song[index]}" + Environment.NewLine;
                    index = Array.IndexOf(singer, search, index + 1);
                }
            }
            MessageBox.Show(msg, "查詢結果"); //查詢結果為msgbox的title

        }
    }
}