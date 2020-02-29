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
            callExecuteSqlScript("Drivers");
        }

        private void callExecuteSqlScript(string scriptName)
        {
            try
            {

                dbTools.ExecuteSqlScript(scriptName + ".sql");
                txtOutput.Text += $"> {scriptName} - SUCCESS!{Environment.NewLine}";
                Console.WriteLine("\n" + scriptName + " - SUCCESS\n");
            }
            catch (Exception ex)
            {
                txtOutput.Text = $"> {scriptName} - ERROR: {ex.Message}";
                Console.WriteLine("\n " + scriptName + " - ERROR: " + ex.Message + "\n");
            }
        }


    }
}
