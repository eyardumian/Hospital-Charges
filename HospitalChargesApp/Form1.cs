using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalChargesApp
{
    public partial class Form1 : Form
    {
        int BaseCharge;
        int MiscCharges;
        int TotalCharges;

        public Form1()
        {
            InitializeComponent();
        }

        private int CalcStayCharges()
        {
            int NumDays = Convert.ToInt32(textBoxNumDays.Text);
            BaseCharge = NumDays * 350;
            return BaseCharge; 
        }

        private int CalcMiscCharges()
        {
            int MedCharge = Convert.ToInt32(textBoxMedCharges.Text);
            int SurgCharges = Convert.ToInt32(textBoxSurCharges.Text);
            int LabFees = Convert.ToInt32(textBoxLabFees.Text);
            int PhysRehabCharges = Convert.ToInt32(textBoxPhysRehab.Text);
            MiscCharges = MedCharge + SurgCharges + LabFees + PhysRehabCharges;
            return MiscCharges;
        }

        private int CalcTotalCharges()
        {
            TotalCharges = BaseCharge + MiscCharges;
            return TotalCharges;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonCalculations_Click(object sender, EventArgs e)
        {
            CalcStayCharges();
            CalcMiscCharges();
            CalcTotalCharges();
            MessageBox.Show("Base Charge: " + BaseCharge.ToString() + "\nMiscellaneous Charges: " + MiscCharges.ToString() + "\nTotal Charges: " +TotalCharges.ToString());
        }
    }
}
