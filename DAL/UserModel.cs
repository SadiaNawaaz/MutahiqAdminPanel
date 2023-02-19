using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDashboard.DAL
{
    public class UserModel
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public string FullName { get; set; }
        //public  string FirstName { get; set; }
        //public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string Password { get; set; }
        public string? Msg { get; set; } = "";
        public int Loginstatus { get; set; }
    }

    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}



