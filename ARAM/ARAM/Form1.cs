using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace ARAM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Init_ChampList();
            Init_RotationList();
        }


        private void Init_ChampList()
        {
            string path = "data\\champ.csv";

            List<string> list = new List<string>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(',');
                        foreach (var value in values)
                        {
                            list.Add(value);
                        }
                    }
                }
            }

            list.Sort((x, y) => String.Compare(x, y));

            foreach (var s in list)
            {
                ChampList.Items.Add(s);
            }
        }

        private void Init_RotationList()
        {
            string path = "data\\rotation.csv";

            List<string> list = new List<string>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(',');
                        foreach (var value in values)
                        {
                            list.Add(value);
                        }
                    }
                }
            }

            list.Sort((x, y) => String.Compare(x, y));

            foreach (var s in list)
            {
                RotationList.Items.Add(s);
            }
        }

        private void Sort(ListBox listBox)
        {
            List<string> list = listBox.Items.Cast<string>().ToList();
            list.Sort((x, y) => String.Compare(x, y));

            listBox.Items.Clear();
            foreach (var s in list)
            {
                listBox.Items.Add(s);
            }
        }

        private void Btn_Ban_Click(object sender, EventArgs e)
        {
            int selectedIndex = ChampList.SelectedIndex;
            if (selectedIndex != -1)
            {
                string s = ChampList.Text;
                BanList.Items.Add(s);
                ChampList.Items.Remove(s);
                RotationList.Items.Remove(s);

                Sort(BanList);
                Sort(ChampList);
                Sort(RotationList);
            }
        }

        private void Btn_Unban_Click(object sender, EventArgs e)
        {
            int selectedIndex = BanList.SelectedIndex;
            if (selectedIndex != -1)
            {
                string s = BanList.Text;
                ChampList.Items.Add(s);
                RotationList.Items.Add(s);
                BanList.Items.RemoveAt(selectedIndex);

                Sort(BanList);
                Sort(ChampList);
                Sort(RotationList);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var random = new Random();

            var rotationList = RotationList.Items.Cast<string>().ToList();
            var banList = BanList.Items.Cast<string>().ToList();
            var champList = ChampList.Items.Cast<string>().ToList();

            foreach(var ban in banList)
            {
                champList.Remove(ban);
                rotationList.Remove(ban);
            }

            var pickedRotationList = rotationList.OrderBy(x => random.Next()).Take(6).ToList();

            foreach (var rot in pickedRotationList)
            {
                champList.Remove(rot);
            }

            //var rotationItems = RotationList.Items.Cast<string>().ToList().OrderBy(x => random.Next()).Take(6).ToList();

            ListBoxA.Items.Clear();
            ListBoxB.Items.Clear();

            var randomItems = champList.OrderBy(x => random.Next()).Take(24).ToList();
            randomItems.AddRange(pickedRotationList);

            for (int i = 0; i < randomItems.Count; ++i)
            {
                if (i % 2 == 0)
                {
                    ListBoxA.Items.Add(randomItems[i]);
                }
                else
                {
                    ListBoxB.Items.Add(randomItems[i]);
                }
            }
        }
    }
}
