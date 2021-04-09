using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TURBOAZ_PROJECT.Utils;

namespace TURBOAZ_PROJECT.Classes
{
    class ClassInfoAdapter
    {
        SqlUtils sqlUtils = SqlUtils.GetInstance();
        public DataTable GetBrands()
        {
            
            String query = @"select *from CAR_BRANDS where ID=72 
                            UNION ALL
                            select* from CAR_BRANDS where ID != 72 ";
            return sqlUtils.GetDataWithAdapter(query);
        }

        public DataTable GetModels(String brandId)
        {
            
            String query = $@"select *from CAR_MODELS where ID=-1
                                UNION ALL
                                select* from CAR_MODELS where ID != -1 AND BRAND_ID={brandId}";
            return sqlUtils.GetDataWithAdapter(query);
        }
        public DataTable GetGeneralInfo(string typeId)
        {
            
            String query = $"SELECT ID,NAME FROM GENERAL_INFO WHERE TYPE_ID={typeId};";
            return sqlUtils.GetDataWithAdapter(query);
        }
        public DataTable GetImage(string adsID)
        {

            String query = $"SELECT ID,CAR_IMAGE FROM TB_ADS_IMAGES WHERE ADS_ID={adsID};";
            return sqlUtils.GetDataWithAdapter(query);
        }

    }
}
