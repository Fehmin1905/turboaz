using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TURBOAZ_PROJECT.Classes;
using TURBOAZ_PROJECT.Utils;

namespace TURBOAZ_PROJECT
{
    public partial class FrmAddCar : Form
    {
        public FrmAddCar()
        {
            InitializeComponent();
        }

        ClassInfoAdapter classInfoAdapter = new ClassInfoAdapter();
        CommonMethods commonMethods = new CommonMethods();
        private void frmAddCar_Load(object sender, EventArgs e)
        {
            
           
            commonMethods.SetBrandData(lkpEditBrand);
            commonMethods.SetGeneralInfo(lkpEditBanType, "1");
            commonMethods.SetGeneralInfo(lkpEditColor, "2");
            commonMethods.SetGeneralInfo(lkpEditPetrolType, "4");
            commonMethods.SetGeneralInfo(lkpEditTrasnmitter, "5");
            commonMethods.SetGeneralInfo(lkpEditCity, "6");
            commonMethods.SetYears(lkpEditYear);
            commonMethods.SetGeneralInfo(lkpEditMotorVolume, "7");
            commonMethods.SetGeneralInfo(lkpEditSpeedBox, "8");
            grdControlPictures.DataSource = classInfoAdapter.GetImage("-1");
        }
        

        private void lkpEditBrand_EditValueChanged(object sender, EventArgs e)
        {
            commonMethods.SetModelData(lkpEditModel,lkpEditBrand.EditValue.ToString());
        }

        

        private void lkpEditBanType_EditValueChanged(object sender, EventArgs e)
        {

        }

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ControlComponentEmpty()
        {
            bool control = true;
            if (lkpEditBrand.EditValue==null)
            {
                lkpEditBrand.ErrorText = "Brendi daxil edin";
                control = false;
            }
            if (lkpEditModel.EditValue==null)
            {
                lkpEditModel.ErrorText = "Modeli daxil edin";
                control = false;
            }
            if (lkpEditBanType.EditValue==null)
            {
                lkpEditBanType.ErrorText = "Ban növü daxil edin";
                control = false;
            }
            if (nmrcUpDownPrice.Value==0)
            {
                MessageBox.Show("Qiymet daxil edin");
                control = false;
            }
            if (lkpEditPetrolType.EditValue==null)
            {
                lkpEditPetrolType.ErrorText = "Yanacaq növü daxil edin";
                control = false;
            }
            if (lkpEditTrasnmitter.EditValue==null)
            {
                lkpEditTrasnmitter.ErrorText = "Ötürücü növü daxil edin";
                control = false;
            }
            if (lkpEditSpeedBox.EditValue==null)
            {
                lkpEditSpeedBox.ErrorText = "Sürətlər qutusunu seçin";
                control = false;
            }
            if (lkpEditYear.EditValue==null)
            {
                lkpEditYear.ErrorText = "Buraxılış tarixini seçin";
                control = false;
            }
            if (lkpEditMotorVolume.EditValue==null)
            {
                lkpEditMotorVolume.ErrorText = "Mühərrikin həcmini seçin";
                control = false;
            }
            if (txtName.Text==null)
            {
                txtName.ErrorText = "Ad daxil edin";
                control = false;
            }
            if (lkpEditCity.EditValue==null)
            {
                lkpEditCity.ErrorText = "Şəhər seçin";
                control = false;
            }
            if (txtEmail.EditValue==null)
            {
                txtEmail.ErrorText = "Email daxil edin";
                control = false;
            }
            if (cardView1.DataRowCount<3)
            {
                MessageBox.Show("Ən azı 3 şəkil daxil edilməlidir");
                control = false;
            }
            return control;
        }
        private void InsertAllInfo()
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(SqlUtils.conString);
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                String insertedID = InsertAds(sqlTransaction);
                InsertAdsImage(sqlTransaction, insertedID);
              
                sqlTransaction.Commit();

                sqlConnection.Close();
                MessageBox.Show("Məlumat yadda saxlanıldı");
                this.Close();
            }
            catch (Exception ex)
            {
                //sqlTransaction.Rollback();
                MessageBox.Show("Xeta bas verdi");
            }
            
            
        }
        private void InsertAdsImage(SqlTransaction sqlTransaction,string adsID)
        {
            DataTable dataTableImages =(DataTable)grdControlPictures.DataSource;
            for (int i=0;i<dataTableImages.Rows.Count;i++)
            {
                DataRow dtRowImage = dataTableImages.Rows[i];
                string query = @"INSERT INTO [dbo].[TB_ADS_IMAGES]
                              (CAR_IMAGE,ADS_ID)
                        VALUES
                              (@CAR_IMAGE,@ADS_ID)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlTransaction.Connection);
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.Parameters.Add("@CAR_IMAGE", SqlDbType.VarBinary).Value = dtRowImage["CAR_IMAGE"];
                sqlCommand.Parameters.Add("@ADS_ID", SqlDbType.Int).Value = adsID;
                sqlCommand.ExecuteNonQuery();
            }
            
        }
        

        private string InsertAds(SqlTransaction sqlTransaction)
        {
            
                string query = @"INSERT INTO [dbo].[TB_ADS]
           ([MODEL_ID]
           ,[BAN_TYPE]
           ,[DISTANCE]
           ,[COLOR_ID]
           ,[PRICE]
           ,[CURRENCY_ID]
           ,[CREDIT_HAVE]
           ,[BARTER]
           ,[FUEL_TYPE_ID]
           ,[TRANSMISSION_ID]
           ,[YEAR]
           ,[MOTOR_VOLUME]
           ,[MOTOR_POWER]
           ,[NOTE]
           ,[ALLOW_WHEELS]
           ,[CENTRAL_CLOSURE]
           ,[LEATHER_SALON]
           ,[SEAT_VENTILATION]
           ,[ABS]
           ,[PARK_RADAR]
           ,[XENON_LAMPS]
           ,[LYUK]
           ,[CONDISIONER]
           ,[REAR_CAMERA]
           ,[RAIN_SENSOR]
           ,[SEAT_HEATING]
           ,[SIDE_CURTAINS]
           ,[NAME]
           ,[CITY_ID]
           ,[EMAIL]
           ,[SPEED_BOX])
     VALUES
           (@MODEL_ID
           ,@BAN_TYPE
           ,@DISTANCE
           ,@COLOR_ID
           ,@PRICE
           ,@CURRENCY_ID
           ,@CREDIT_HAVE
           ,@BARTER
           ,@FUEL_TYPE_ID
           ,@TRANSMISSION_ID
           ,@YEAR
           ,@MOTOR_VOLUME
           ,@MOTOR_POWER
           ,@NOTE
           ,@ALLOW_WHEELS
           ,@CENTRAL_CLOSURE
           ,@LEATHER_SALON
           ,@SEAT_VENTILATION
           ,@ABS
           ,@PARK_RADAR
           ,@XENON_LAMPS
           ,@LYUK
           ,@CONDISIONER
           ,@REAR_CAMERA
           ,@RAIN_SENSOR
           ,@SEAT_HEATING
           ,@SIDE_CURTAINS
           ,@NAME
           ,@CITY_ID
           ,@EMAIL
           ,@SPEED_BOX); SELECT SCOPE_IDENTITY();";

                
                SqlCommand sqlCommand = new SqlCommand(query, sqlTransaction.Connection);
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.Parameters.Add("MODEL_ID", SqlDbType.Int).Value = lkpEditModel.EditValue;
                sqlCommand.Parameters.Add("BAN_TYPE", SqlDbType.Int).Value = lkpEditBanType.EditValue;
                sqlCommand.Parameters.Add("DISTANCE", SqlDbType.Int).Value = nmrcUpDownDistance.Value;
                sqlCommand.Parameters.Add("COLOR_ID", SqlDbType.Int).Value = lkpEditColor.EditValue;
                sqlCommand.Parameters.Add("PRICE", SqlDbType.Int).Value = nmrcUpDownPrice.Value;
                sqlCommand.Parameters.Add("CURRENCY_ID", SqlDbType.Int).Value = rdGrpCurrency.EditValue;
                sqlCommand.Parameters.Add("CREDIT_HAVE", SqlDbType.Bit).Value = chckEditCredit.Checked;
                sqlCommand.Parameters.Add("BARTER", SqlDbType.Bit).Value = chckEditBarter.Checked;
                sqlCommand.Parameters.Add("FUEL_TYPE_ID", SqlDbType.Int).Value = lkpEditPetrolType.EditValue;
                sqlCommand.Parameters.Add("TRANSMISSION_ID", SqlDbType.Int).Value = lkpEditTrasnmitter.EditValue;
                sqlCommand.Parameters.Add("YEAR", SqlDbType.Int).Value = lkpEditYear.EditValue;
                sqlCommand.Parameters.Add("MOTOR_VOLUME", SqlDbType.Int).Value = lkpEditMotorVolume.EditValue;
                sqlCommand.Parameters.Add("MOTOR_POWER", SqlDbType.Int).Value = nmrcUpDownMotorPower.Value;
                sqlCommand.Parameters.Add("NOTE", SqlDbType.NVarChar).Value = mmEditAdditionalInfo.EditValue;
                sqlCommand.Parameters.Add("ALLOW_WHEELS", SqlDbType.Bit).Value = chckEditYungulLehimliDIsk.Checked;
                sqlCommand.Parameters.Add("CENTRAL_CLOSURE", SqlDbType.Bit).Value = chckEditMerkeziQapanma.Checked;
                sqlCommand.Parameters.Add("LEATHER_SALON", SqlDbType.Bit).Value = chckEditDeriSalon.Checked;
                sqlCommand.Parameters.Add("SEAT_VENTILATION", SqlDbType.Bit).Value = chckEditOturacaqVentilasiya.Checked;
                sqlCommand.Parameters.Add("ABS", SqlDbType.Bit).Value = chckEditABS.Checked;
                sqlCommand.Parameters.Add("PARK_RADAR", SqlDbType.Bit).Value = chckEdirParkRadari.Checked;
                sqlCommand.Parameters.Add("XENON_LAMPS", SqlDbType.Bit).Value = chckEditKsenonLampa.Checked;
                sqlCommand.Parameters.Add("LYUK", SqlDbType.Bit).Value = chckEditLyuk.Checked;
                sqlCommand.Parameters.Add("CONDISIONER", SqlDbType.Bit).Value = chckEditKondisioner.Checked;
                sqlCommand.Parameters.Add("REAR_CAMERA", SqlDbType.Bit).Value = chckEditArxaKamera.Checked;
                sqlCommand.Parameters.Add("RAIN_SENSOR", SqlDbType.Bit).Value = chckEditYagisSensoru.Checked;
                sqlCommand.Parameters.Add("SEAT_HEATING", SqlDbType.Bit).Value = chckEditOturacaqIsidilmesi.Checked;
                sqlCommand.Parameters.Add("SIDE_CURTAINS", SqlDbType.Bit).Value = chckEditYanPerdeler.Checked;
                sqlCommand.Parameters.Add("NAME", SqlDbType.NVarChar).Value = txtName.EditValue;
                sqlCommand.Parameters.Add("CITY_ID", SqlDbType.Int).Value = lkpEditCity.EditValue;
                sqlCommand.Parameters.Add("EMAIL", SqlDbType.NVarChar).Value = txtEmail.EditValue;
                sqlCommand.Parameters.Add("SPEED_BOX", SqlDbType.Int).Value = lkpEditSpeedBox.EditValue;
              
                
             
                return sqlCommand.ExecuteScalar().ToString();
               
        }

       
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void grpControlPictures_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button==grpControlPictures.CustomHeaderButtons[0])
            {
                
                openFileDialog.Filter = "Image files | *.jpg;*.jpeg;*.png;";
                openFileDialog.Multiselect = true;
                DataTable dataTable = (DataTable)grdControlPictures.DataSource;
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        dataTable.Rows.Add(0, GetByteImage(fileName));
                        GetByteImage(fileName);
                    }
                }
            }

            
        }

        private void GetImageDataSource()
        {

        }
        private byte[] GetByteImage(string fileName)
        {
            byte[] imgByteArray = null;
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            imgByteArray = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            return imgByteArray;
        }

        private void grpControlPictures_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ControlComponentEmpty())
            {
                if (MessageBox.Show("Elanı yerləşdirməyə əminsiniz ?","Sual",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    InsertAllInfo();
                }
            }

        }
    }
}
