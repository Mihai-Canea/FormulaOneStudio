using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//DLL
using FormulaOneDLL;

namespace FormulaOneStudio
{
    public partial class Form1 : Form
    {
        static DbTools dbTools = new DbTools();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateCountry_Click(object sender, EventArgs e)
        {
            callExecuteSqlScript("Countries");
        }

        private void btnCreateTeams_Click(object sender, EventArgs e)
        {
            callExecuteSqlScript("Teams00");
        }

        private void btnCreateDrivers_Click(object sender, EventArgs e)
        {
            callExecuteSqlScript("Drivers00");
        }

        private void callExecuteSqlScript(string scriptName)
        {
            try
            {

                dbTools.ExecuteSqlScript(scriptName + ".sql");
                txtOutput.Text = $"Create {scriptName} - SUCCESS!";
                Console.WriteLine("\nCreate " + scriptName + " - SUCCESS\n");
            }
            catch (Exception ex)
            {
                txtOutput.Text = $"Crearte {scriptName} - ERROR: {ex.Message}";
                Console.WriteLine("\nCreate " + scriptName + " - ERROR: " + ex.Message + "\n");
            }
        }


    }
}
