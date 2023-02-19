using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDashboard.DAL
{
    public class ListViewModel
    {
        public List<UtilityDemand> UtilityDemand { get; set; }
        public List<PlotSize> PlotSize { get; set; }
        public List<GasSupplyRequirement> GasSupplyRequirement { get; set; }


        public List<WaterPiperequirement> WaterPiperequirement { get; set; }
        public List<BusinessStatus> BusinessStatus { get; set; }
        public List<InvestmentType> InvestmentType { get; set; }

    }


    public class UtilityDemand
    {
        public int UtilitydemandId { get; set; }
        public  string UtilitydemandTitle { get; set; }

    }

    public class PlotSize
    {
        public int PlotSizeId { get; set; }
        public string PlotSizeTitle { get; set; }

    }

    public class GasSupplyRequirement
    {
        public int GasSupplyRequirementId { get; set; }
        public string gasSupplyRequirement { get; set; }
    }



    public class WaterPiperequirement
    {
        public int WaterPipeId { get; set; }
        public string WaterPipeTitle { get; set; }
    }


    public class BusinessStatus
    {
        public int BusinessStatusId { get; set; }
        public string BusinessStatusTitle { get; set; }
    }

    public class InvestmentType
    {
        public int InvestmentTypeId { get; set; }
        public string InvestmentTypeTitle { get; set; }
    }
}
