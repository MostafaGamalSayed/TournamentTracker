using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentTrackUI
{
    public partial class CreatePrizeForm : Form
    {
        List<string> ErrorMessages = new List<string>();

        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
     
            if (ValidateForm())
            {
                MessageBox.Show("All things ar ok", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                var message = string.Join(Environment.NewLine, ErrorMessages);
                MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
        }


        private bool ValidateForm()
        {

            ErrorMessages.Clear();

            bool output = true; 

            int PlaceNumber = 0;
            bool PlaceNumberValid = int.TryParse(PlaceNumberValue.Text, out PlaceNumber);
            if (!PlaceNumberValid)
            {
                output = false;
                if(PlaceNumberValue.Text.Length != 0)
                {
                    ErrorMessages.Add("Please enter a valid place number.");
                }
                else
                {
                    ErrorMessages.Add("The place number field is required.");
                }
               
            }
           
            if (PlaceNameValue.Text.Length == 0)
            {
                output = false;
                ErrorMessages.Add("The place name field is required.");
            }

            return output;
        }
    }
}
