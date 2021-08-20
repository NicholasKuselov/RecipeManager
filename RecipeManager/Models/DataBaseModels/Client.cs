using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Models.DataBaseModels
{
    [Table("clients")]
    class Client
    {
        [Key]
        public int idclient { get; set; }
        public string phone { get; set; }
        public string contact_information { get; set; }
        public string comments { get; set; }
        public string name { get; set; }
    }
}
