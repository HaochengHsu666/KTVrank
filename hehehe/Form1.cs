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
        string[] song = new string[] { "�^��", "�Q���l��", "on my way", "��M�n�Q�A", "�n���e��", "�t�i��", "�Ͻ��q" };
        string[] singer = new string[] { "�P�N��", "���a�E", "Alen Walker", "�����", "�i���H", "������", "�쭵����" };
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
            string msg = $"�䤣��{search}";
            int index = Array.IndexOf(singer, search);
            //��index�䤣��� ��-1
            if (index >= 0)
            {
                msg = "�ƦW\t�q��\t�q��" + Environment.NewLine;
                while (index >= 0) //�u�nindex>=0�N�@�����榹�j��
                {
                    msg += $"{no[index]}\t{singer[index]}\t{song[index]}" + Environment.NewLine;
                    index = Array.IndexOf(singer, search, index + 1);
                }
            }
            MessageBox.Show(msg, "�d�ߵ��G"); //�d�ߵ��G��msgbox��title

        }
    }
}