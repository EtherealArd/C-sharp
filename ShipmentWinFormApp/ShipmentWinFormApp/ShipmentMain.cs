using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel.Contracts;
using DataModel.Entities;
using DataModel.MSSQLServer;



namespace ShipmentWinFormApp
{
    public partial class ShipmentMain : Form
    {
        
        public IDataStorage storage;// Interface type reference
        public List<Shipment> shipments = null; //Collection of Shipment data
        public List<object> groupedData = null; //Collection of groupped data
        public bool isCheckBoxCheckedFirstTime = false; // Some flag for proper work gridView
       

        public ShipmentMain()
        {
            InitializeComponent();
            storage = new DataAccess();
            storage.Massage += Storage_Massage;
            

#region Set Handlers for Checkboxe events

            checkBoxDate.CheckedChanged += CheckBoxDate_CheckedChanged;
            checkBoxOrganization.CheckedChanged += CheckBoxDate_CheckedChanged;
            checkBoxCity.CheckedChanged += CheckBoxDate_CheckedChanged;
            checkBoxCountry.CheckedChanged += CheckBoxDate_CheckedChanged;
            checkBoxManager.CheckedChanged += CheckBoxDate_CheckedChanged;
#endregion

        }

        private void Storage_Massage(object sender, string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// Handler for checkbox CheckedChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (shipments == null)
                    throw new Exception("Отсуствуют данные в таблице");

                
                CheckBox checkBoxChanged = ((CheckBox)sender);
                groupedData = storage.GetShipmentsGroupedBy(checkBoxDate.Checked, checkBoxOrganization.Checked, checkBoxCity.Checked, checkBoxCountry.Checked, checkBoxManager.Checked);
                gridViewShipment.DataSource = groupedData;
                ShowCheckedGropingColumns(checkBoxChanged);             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Show grouped data from database and hide empty collumns wich is not necessary
        /// </summary>
        /// <param name="changedCheckBox"></param>
        private void ShowCheckedGropingColumns(CheckBox changedCheckBox)
        {
            string columnName = changedCheckBox.Tag.ToString();

            if (!isCheckBoxCheckedFirstTime)
            {
                HideAllGroupedColumns();
                isCheckBoxCheckedFirstTime = true;
            }

            if (changedCheckBox.Checked == true)
                gridViewShipment.Columns[columnName].Visible = true;

            if (changedCheckBox.Checked == false)
                gridViewShipment.Columns[columnName].Visible = false;

            if (checkBoxDate.Checked == false && checkBoxOrganization.Checked == false && checkBoxCity.Checked == false && checkBoxCountry.Checked == false && checkBoxManager.Checked == false)
            {
                isCheckBoxCheckedFirstTime = false;
                ShowAllColumns();
                shipments = storage.GetShipments();
                gridViewShipment.DataSource = shipments;
            }


        }
        /// <summary>
        /// Method hides all groupded collumns 
        /// </summary>
        private void HideAllGroupedColumns()
        {
            gridViewShipment.Columns["Date"].Visible = false;
            gridViewShipment.Columns["Organization"].Visible = false;
            gridViewShipment.Columns["City"].Visible = false;
            gridViewShipment.Columns["Country"].Visible = false;
            gridViewShipment.Columns["Manager"].Visible = false;
        }
        /// <summary>
        /// Method shows all groupded collumns 
        /// </summary>
        private void ShowAllColumns()
        {
            gridViewShipment.Columns["Date"].Visible = true;
            gridViewShipment.Columns["Organization"].Visible = true;
            gridViewShipment.Columns["City"].Visible = true;
            gridViewShipment.Columns["Country"].Visible = true;
            gridViewShipment.Columns["Manager"].Visible = true;
        }

        /// <summary>
        /// Method restore checkbox flags to default condition
        /// </summary>
        private void RestoreDefaultCheckBoxValues()
        {
            checkBoxDate.Checked = false;
            checkBoxOrganization.Checked = false;
            checkBoxCity.Checked = false;
            checkBoxCountry.Checked = false;
            checkBoxManager.Checked = false;
        }

        /// <summary>
        /// Method calls another method from data access layer and then fill dataGriedView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetAllData_Click(object sender, EventArgs e)
        {
            RestoreDefaultCheckBoxValues();

            shipments = null;
            groupedData = null;

            shipments = storage.GetShipments();
            if (shipments != null)
            {
                gridViewShipment.DataSource = shipments;
                ShowAllColumns();
            }
            else
            {
                MessageBox.Show("Отсуствуют данные");
            }
        }
        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
