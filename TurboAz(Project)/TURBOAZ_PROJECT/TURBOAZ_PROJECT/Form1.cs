using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TURBOAZ_PROJECT.Classes;
using TURBOAZ_PROJECT.Utils;

namespace TURBOAZ_PROJECT
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            FrmAddCar frmAddCar = new FrmAddCar();
            frmAddCar.ShowDialog();
        }

        private void cmbBoxBrands_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        CommonMethods commonMethods = new CommonMethods();

        private void FrmHome_Load(object sender, EventArgs e)
        {
            




            commonMethods.SetBrandData(lkpEditBrand);
            commonMethods.SetGeneralInfo(lkpEditCurrency, "3");
            commonMethods.SetGeneralInfo(lkpEditCity, "6");
            commonMethods.SetYears(lkpEditMinimumYear);
            commonMethods.SetYears(lkpEditMaximumYear);
            
        }
        
        private void lkpEditBrand_EditValueChanged(object sender, EventArgs e)
        {
            commonMethods.SetModelData(lkpEditModel, lkpEditBrand.EditValue.ToString());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetCars();
        }
        private void GetCars()
        {
            string query = $@"SELECT 
                    ADS.[ID]
                    ,ADS.[PRICE]
                    ,BRD.BRAND_NAME+ ' '+MDL.MODEL_NAME CAR_FULL_NAME
                    ,ADS.YEAR
                    ,ADS.MOTOR_VOLUME
                    ,ADS.DISTANCE
                    ,GN.NAME CITY_NAME
                    ,(SELECT TOP(1) IMG.CAR_IMAGE FROM TB_ADS_IMAGES IMG WHERE IMG.ADS_ID=ADS.ID) CAR_IMAGE
                      FROM [dbo].[TB_ADS] ADS
                    JOIN CAR_MODELS MDL ON MDL.ID=ADS.MODEL_ID
                    JOIN CAR_BRANDS BRD ON MDL.BRAND_ID=BRD.ID
                    JOIN GENERAL_INFO GN ON GN.ID=ADS.CITY_ID
                    JOIN GENERAL_INFO GN1 ON GN1.ID=ADS.MOTOR_VOLUME
                    WHERE CURRENCY_ID={lkpEditCurrency.EditValue} ";

            //AND ADS.CREDIT_HAVE={chckEditCredit.EditValue} AND ADS.BARTER={chckEditBarter.EditValue}
            if (lkpEditBrand.EditValue!=null && (int)lkpEditBrand.EditValue!=72)
            {
                query = query + $" AND MDL.BRAND_ID={lkpEditBrand.EditValue}";
            }
            
            if (lkpEditModel.EditValue!=null &&(int)lkpEditModel.EditValue!=-1)
            {
                query = query + $" AND ADS.[MODEL_ID]={lkpEditModel.EditValue}";
            }
            if (txtMinPrice.EditValue!=null && txtMinPrice.Text!="")
            {
                query = query + $" AND ADS.[PRICE]>={txtMinPrice.EditValue}";
            }
            if (txtMaxPrice.EditValue!=null && txtMaxPrice.Text != "")
            {
                query = query + $" AND ADS.[PRICE] <={txtMaxPrice.EditValue}";
            }
            if (lkpEditMinimumYear.EditValue!=null)
            {
                query = query + $" AND ADS.[YEAR]>={lkpEditMaximumYear.EditValue}";
            }
            if (lkpEditMaximumYear.EditValue!=null)
            {
                query = query + $" AND ADS.[YEAR]<={lkpEditMaximumYear.EditValue}";
            }
            if (lkpEditCity.EditValue!=null)
            {
                query = query + $" AND ADS.[CITY_ID]={lkpEditCity.EditValue}";
            }
            DataTable dtTableCars = SqlUtils.GetInstance().GetDataWithAdapter(query);
            grdControlHome.DataSource = dtTableCars;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            lkpEditBrand.EditValue = "Bütün markalar";
        }
    }
}
