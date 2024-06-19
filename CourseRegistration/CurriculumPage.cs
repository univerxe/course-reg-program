using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistration
{
    public partial class CurriculumPage : Form
    {
        private Dictionary<CheckBox, List<Button>> buttonGroups;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public CurriculumPage()
        {
            InitializeComponent();
            GroupButtons();
            InitializeDefaultStates();
        }

        private void GroupButtons()
        {
            buttonGroups = new Dictionary<CheckBox, List<Button>>();

            CheckBox[] checkBoxes = { checkBoxY, checkBoxG, checkBoxB };
            string[] prefixes = { "y_btn", "g_btn", "b_btn" };

            int borderRadius = 20;  // Radius of the rounded corners

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                List<Button> groupedButtons = new List<Button>();
                foreach (Control control in Controls)
                {
                    if (control is Button button && button.Name.StartsWith(prefixes[i]))
                    {
                        // Set the region of the button to be rounded
                        IntPtr ptr = CreateRoundRectRgn(0, 0, button.Width, button.Height, borderRadius, borderRadius);
                        button.Region = Region.FromHrgn(ptr);
                        groupedButtons.Add(button);
                    }
                }
                buttonGroups.Add(checkBoxes[i], groupedButtons);
                checkBoxes[i].CheckedChanged += CheckBox_CheckedChanged;
            }
        }

        private void InitializeDefaultStates()
        {
            checkBoxAll.Checked = true; 
            checkBoxAll.CheckedChanged += CheckBoxAll_CheckedChanged; 

            foreach (CheckBox chk in buttonGroups.Keys)
            {
                chk.Checked = checkBoxAll.Checked;
                CheckBox_CheckedChanged(chk, EventArgs.Empty); 
            }
        }

        private void CheckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox chkAll)
            {
                bool isChecked = chkAll.Checked;
                foreach (CheckBox chk in buttonGroups.Keys)
                {
                    chk.Checked = isChecked; 
                    CheckBox_CheckedChanged(chk, EventArgs.Empty); 
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox && buttonGroups.TryGetValue(checkBox, out List<Button> buttons))
            {
                foreach (Button button in buttons)
                {
                    button.Visible = checkBox.Checked; 
                }
            }
        }
    }
}


