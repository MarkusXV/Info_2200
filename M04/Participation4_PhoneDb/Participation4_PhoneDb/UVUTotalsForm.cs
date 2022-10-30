using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation4_PhoneDb
{
  public partial class UVUTotalsForm : Form
  {
    public UVUTotalsForm()
    {
      InitializeComponent();
    }

        private void UVUTotalsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet1.UVUPhoneNumbersSP' table. You can move, or remove it, as needed.
            this.uVUPhoneNumbersSPTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet1.UVUPhoneNumbersSP);

        }
    }
}
