using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UnityWizardCleaner
{
    public partial class Form1 : Form
    {
        private const string wizardPath = "RecentlyUsedProjectPaths";

        List<string> regPaths = new List<string>(); // список всех значений
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Unity Technologies\Unity Editor 5.x", true);

        public Form1()
        {
            InitializeComponent();
            GetWizardValues();
        }

        private void GetWizardValues()
        {
            foreach (string item in key.GetValueNames())
            {
                if (item.Contains(wizardPath))
                {
                    byte[] pathName = key.GetValue(item) as byte[];

                    // добавляем значения в список и в выводимый на экран листинг
                    regPaths.Add(item);
                    projectList.Items.Add(System.Text.Encoding.UTF8.GetString(pathName));
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                key.DeleteValue(regPaths[projectList.SelectedIndex]);   // сначала удаляем в реестре, потом в списках

                regPaths.RemoveAt(projectList.SelectedIndex);
                projectList.Items.RemoveAt(projectList.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите проект, который необходимо убрать из списка.");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
