using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5_App_DDI.Models
{
    public partial class Gamer
    {
        //scalar properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int GameScore { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public bool IsActivated { get; set; }
    }
}
