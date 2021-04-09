using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TURBOAZ_PROJECT.Classes
{
    class CommonMethods
    {
        ClassInfoAdapter classInfoAdapter = new ClassInfoAdapter();
        public void SetGeneralInfo(LookUpEdit lkUpEditGenInfo, String typeID)
        {
            lkUpEditGenInfo.Properties.DataSource = classInfoAdapter.GetGeneralInfo(typeID);
            lkUpEditGenInfo.Properties.DisplayMember = "NAME";
            lkUpEditGenInfo.Properties.ValueMember = "ID";
        }


        public void SetYears(LookUpEdit lkpEditYear)
        {
            List<int> listYears = new List<int>();
            int currentYear = DateTime.Now.Year;
            for (int i = 1960; i <= currentYear; i++)
            {
                listYears.Add(i);
            }
            lkpEditYear.Properties.DataSource = listYears;
        }

        public void SetBrandData(LookUpEdit lkpEditBrand)
        {

            lkpEditBrand.Properties.DataSource = classInfoAdapter.GetBrands();
            lkpEditBrand.EditValue = 72;
            lkpEditBrand.Properties.DisplayMember = "BRAND_NAME";
            lkpEditBrand.Properties.ValueMember = "ID";
        }
        public void SetModelData(LookUpEdit lkpEditModel,string brandID)
        {
            lkpEditModel.Properties.DataSource = classInfoAdapter.GetModels(brandID);
            lkpEditModel.EditValue = -1;
            lkpEditModel.Properties.DisplayMember = "MODEL_NAME";
            lkpEditModel.Properties.ValueMember = "ID";
        }
    }
}
