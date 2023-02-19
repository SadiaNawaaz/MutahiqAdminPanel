using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDashboard.DAL
{
    internal class FileViewModel
    {
    }

    public class FileAttachment
    {

        public List<Files> selectedFiles { get; set; }

        
        public int MasterID { get; set; }



    }

    public class Files
    {
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public bool isdelete { get; set; } = false;


    }
    public class Attachments
    {
        public int DocumentMiD { get; set; }
        public int TransMasterId { get; set; }
        public int TransactionNo { get; set; }
        public string FileName { get; set; }
        public bool isdelete { get; set; } = false;

        public string UploadedBy { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
