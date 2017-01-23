using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractSearchApp
{
    public partial class MainForm : Form
    {
        Controller _controller = new Controller();
        List<EimzaUsers> _userList = new List<EimzaUsers>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CBContractNumber.Checked)
            {
                _userList = _controller.GetDataByContractNumber(int.Parse(txtId.Text.ToString()));
                FillPersonInfoList();

            }
            else if (CBFiN.Checked)
            {
                _userList = _controller.GetDataByFIN(txtId.Text.ToString());
                FillPersonInfoList();
            }
            //else if (CBDateTime.Checked)
            //{
            //    _userList = _controller.GetDataByDateTime(DateTime.Parse(dtFrom.Text), DateTime.Parse(dtToDate.Text));
            //    FillPersonInfoList();
            //}
            else
            {
                MessageBox.Show("her hansi varianti secin");
            }
        }
        public void FillPersonInfoList()
        {
            foreach (var user in _userList)
            {
                string pm = user.PayedMoney == 0 ? "ödenilmeyib" : "ödenilib";
                string[] lv = { user.Name, user.Surname, user.PİN, user.Phone, user.Mail, user.Adress, user.PayedMoney.ToString(), pm, user.PayedDate.ToString() };
                var listViewItem = new ListViewItem(lv);
                lstUserInformation.Items.Add(listViewItem);
            }
        }
        private void CBContractNumber_CheckedChanged(object sender, EventArgs e)
        {
            CBFiN.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstUserInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
       
    }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CBDateTime.Checked)
            {
                _userList = _controller.GetDataByDateTime(DateTime.Parse(dtFrom.Text), DateTime.Parse(dtToDate.Text));
                FillPersonInfoList();
            }
        }
    } }




