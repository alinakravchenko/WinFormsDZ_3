namespace WinFormsDZ_3
{
    public partial class Form1 : Form
    {
        MenuStrip menuTop;
        public Form1()
        {
            InitializeComponent();
            menuTop = new MenuStrip();
            menuTop.Dock = DockStyle.Top;
            this.Controls.Add(menuTop);
            btnTopLevelMenu.Click += BtnTopLevelMenu_Click;
            btnSubItem.Click += BtnSubItem_Click;
            TopLevelMenu.Click += TopLevelMenu_Click;
            SubItem.Click += TopLevelMenu_Click;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label.Text = "Добавления пунктов меню";
            label.ForeColor = Color.Black;
            timer.Stop();
        }

        private void TopLevelMenu_Click(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;
            s.BackColor = Color.White;
        }

        private void BtnSubItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem temp;
            bool flag = false;
            if (menuTop.Items.Count < 1)
            {
                label.Text = $"У вас нет ни одного пункта меню";
                label.ForeColor = Color.Red;
                label.Visible = true;
                timer.Start();
                return;
            }
            if (TopLevelMenu.Text != "")
            {
                for (int i = 0; i < menuTop.Items.Count; i++)
                {
                    if (menuTop.Items[i].Text == TopLevelMenu.Text)
                    {
                        if (SubItem.Text != "")
                        {
                            temp = (ToolStripMenuItem)menuTop.Items[i];
                            temp.DropDownItems.Add(SubItem.Text);
                            label.Text = $"{SubItem.Text} - добавлен в меню - {TopLevelMenu.Text}";
                            label.ForeColor = Color.Green;
                            timer.Start();
                            flag = true;
                        }
                        else
                        {
                            SubItem.BackColor = Color.Red;
                            MessageBox.Show("Укажите название пункта подменю", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                if (!flag)
                {
                    label.Text = $"{TopLevelMenu.Text} - нет такого меню";
                    label.ForeColor = Color.Red;
                    timer.Start();
                }
            }
            else
            {
                TopLevelMenu.BackColor = Color.Red;
                MessageBox.Show("Укажите название пункта меню", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void BtnTopLevelMenu_Click(object sender, EventArgs e)
        {
            if (TopLevelMenu.Text != "")
            {
                menuTop.Items.Add(TopLevelMenu.Text);
                label.Text = $"{TopLevelMenu.Text} - добавлен в меню";
                label.ForeColor = Color.Green;
                timer.Start();
            }
            else
            {
                TopLevelMenu.BackColor = Color.Red;
                MessageBox.Show("Укажите название пункта меню", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}