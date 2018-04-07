using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsApp.Models
{
    public class FriendModel
    {
        public int change { get; set; }

        [Required(ErrorMessage ="Vnesete id")]
        [Range(0,200, ErrorMessage = "Mora da e pomegu 0 i 200")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vnesete ime")]
        public String Ime { get; set; }

        [Required(ErrorMessage = "Vnesete mesto na ziveenje")]
        public String MestoZiveenje { get; set; }
    }
}
