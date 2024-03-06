using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace MatchingAddressess
{
    public class MatchingViewModel
    {
        public ObservableCollection<MatchingModel> Data { get; set; }
        public MatchingViewModel()
        {
            this.Data = new ObservableCollection<MatchingModel>();
            Data.Add(new MatchingModel { St_Prefix = "1", St_Name = "OFF END OF SR 1172", St_Type = "", St_Suffix = " ", PJ = "AHOSKIE", CityZip = "NA/NA" ,UniqueSeqofStreet= 1 });
            Data.Add(new MatchingModel { St_Prefix = "2", St_Name = "OFF END OF SR 1172", St_Type = "", St_Suffix = " ", PJ = "COFIELD", CityZip = "NA/NA", UniqueSeqofStreet = 1 });
            Data.Add(new MatchingModel { St_Prefix = "3", St_Name = "OFF END OF SR 1172", St_Type = "", St_Suffix = " ", PJ = "COMO", CityZip = "NA/NA", UniqueSeqofStreet = 1 });
            Data.Add(new MatchingModel { St_Prefix = "4", St_Name = "OFF END OF SR 1172", St_Type = "", St_Suffix = " ", PJ = "COUNTY", CityZip = "NA/NA", UniqueSeqofStreet = 1 });
            Data.Add(new MatchingModel { St_Prefix = "5", St_Name = "OFF END OF SR 1172", St_Type = "", St_Suffix = " ", PJ = "HARRELLSVILLE", CityZip = "NA/NA", UniqueSeqofStreet = 1 });
            Data.Add(new MatchingModel { St_Prefix = "6", St_Name = "OFF END OF SR 1172", St_Type = "", St_Suffix = " ", PJ = "MURFREESBORO", CityZip = "NA/NA", UniqueSeqofStreet = 1 });

        }   
    }  
}
