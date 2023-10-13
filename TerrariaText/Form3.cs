using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace TerrariaText
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label11.Visible = false;
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            void AddLine(string str, string end = "")
            {
                int l = richTextBox1.Text.Length;
                richTextBox1.AppendText(str);

                richTextBox1.Select(l, 4);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                richTextBox1.SelectionLength = 0;

                richTextBox1.Select(l + 5, richTextBox1.Text.Length - (l + 5));
                richTextBox1.SelectionColor = Color.White;
                richTextBox1.SelectionFont = richTextBox1.Font;
                richTextBox1.SelectionLength = 0;

                if (end != "")
                {
                    l = richTextBox1.Text.Length;
                    end = " " + end;
                    richTextBox1.AppendText(end);
                    richTextBox1.Select(l, end.Length);
                    richTextBox1.SelectionColor = Color.Gray;
                    richTextBox1.SelectionFont = new Font("Courier New", 8, FontStyle.Italic);
                    richTextBox1.SelectionLength = 0;
                }
                richTextBox1.AppendText("\n");
            }
            for (int i = 0; i < ItemList.Items.Count; i++)
            {
                string l = ItemList.Items[i];
                string start = l.Substring(0, l.Length - l.Substring(l.LastIndexOf(" ") - 4).Length + 1);
                string end = l.Contains('[') ? l.Substring(l.LastIndexOf(" ") + 1) : "";
                AddLine(start, end);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            richTextBox1.Text = "";
            void AddLine(string str, string end = "")
            {
                int l = richTextBox1.Text.Length;
                richTextBox1.AppendText(str);

                richTextBox1.Select(l, 4);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                richTextBox1.SelectionLength = 0;

                richTextBox1.Select(l + 5, richTextBox1.Text.Length - (l + 5));
                richTextBox1.SelectionColor = Color.White;
                richTextBox1.SelectionFont = richTextBox1.Font;
                richTextBox1.SelectionLength = 0;

                if (end != "")
                {
                    l = richTextBox1.Text.Length;
                    end = " " + end;
                    richTextBox1.AppendText(end);
                    richTextBox1.Select(l, end.Length);
                    richTextBox1.SelectionColor = Color.Gray;
                    richTextBox1.SelectionFont = new Font("Courier New", 8, FontStyle.Italic);
                    richTextBox1.SelectionLength = 0;
                }
                richTextBox1.AppendText("\n");
            }
            List<string> NewItemList2 = new List<string>(ItemList.Items);
            List<string> NewItemList = new List<string>(ItemList.Items);
            List<string> ItemNameList = new List<string>(ItemList.Items);
            List<string> SortedNameList = new List<string>(ItemList.Items);
            List<string> NumberList = new List<string>(ItemList.Items);
            for (int i = 0; i < NewItemList.Count; i++)
            {
                NumberList[i] = NewItemList[i].Substring(0, 7);
                ItemNameList[i] = NewItemList[i].Substring(7);
                NewItemList2[i] = NewItemList[i].Substring(7);
            }

            SortedNameList = ItemNameList;
            SortedNameList.Sort();

            for (int i = 0; i < SortedNameList.Count; i++)
            {
                NewItemList[i] = NumberList[NewItemList2.IndexOf(SortedNameList[i])] + SortedNameList[i];
            }

            for (int i = 0; i < NewItemList.Count; i++)
            {
                string l = NewItemList[i];
                string start = l.Substring(0, l.Length - l.Substring(l.LastIndexOf(" ") - 4).Length + 1);
                string end = l.Contains('[') ? l.Substring(l.LastIndexOf(" ") + 1) : "";
                AddLine(start, end);
            }
            label11.Visible = false;
        }
    }
}