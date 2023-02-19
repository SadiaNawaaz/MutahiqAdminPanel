using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDashboard.DAL
{
    public class BookingModel
    {

        public int RpId { get; set; }
        public int LoginId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string? CNIC { get; set; }
        //[Required]
        public string? PassPortNo { get; set; }
        [Required]
        public string NTNNo { get; set; }
        public string? Contact1 { get; set; }
        public string? Contact2 { get; set; }
        public string? WhatsAppNo { get; set; }
        public string? FaxNo { get; set; }

        public string? EmailID { get; set; }
        public string? PreferredPlotSize { get; set; }
        public int PreferredPlotSizeId { get; set; }
        public string? TypeOfIndustry { get; set; }
        public string? Investmenttype { get; set; }
        public string? InvestmenttypeId { get; set; }
        public string? PaymentOption { get; set; }
        public string? Skilled { get; set; }
        public string? UnSkilled { get; set; }
        public int UtilityDemandId { get; set; }
        public string? UtilityDemand { get; set; }
        public int GasSupplyRequirmentsId { get; set; }

        public string? GasSupplyRequirments{get; set; }
        public int waterPipeRequirmentsId { get; set; }

        public string? CompanyName { get; set; }
        public string? CompanyAddress { get; set; }
        public string? CompanyPhoneNo { get; set; }
        public string? CompanyFaxNo { get; set; }
        public string? CompanyEmailID { get; set; }
        public string? BusinessStatus { get; set; }
        public string Bookingdate { get; set; } = DateTime.Now.ToString();
        public int Status { get; set; }
        public FileAttachment attachment { get; set; }
        ///public List<BookingModelDetail> bookingModelDetails { get; set; }
    }

    public class BookingModelDetail
    {
        public int id { get; set; }
        public int MasterID { get; set; }
        public string  FileName { get; set; }
    }
}
