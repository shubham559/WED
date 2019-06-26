using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WED
{
    public partial class Lab_08Form : Form
    {
        public string Username { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the constructor for the lab_08 form
        /// </summary>

        public Lab_08Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        /// <summary>
        /// This is the evevnt handler for the submit_button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            Username = Name_Text_Box.Text;
            UserAge = float.Parse(Age_Text_Box.Text);



            Output_Label.Text = Name_Text_Box.Text + " " + Age_Text_Box.Text;

            //   Name_Text_Box.Text = "";
            // or but we use second one
            Name_Text_Box.Text = string.Empty;
            Age_Text_Box.Text = string.Empty;
 

        }
        /// <summary>
        /// This is the event handler for the Lab_08 form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab_08Form_Load(object sender, EventArgs e)
        {
            Submit_Button.Enabled = false;
        }

        private void Age_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Submit_Button.Enabled = true;
        }
    }
}
