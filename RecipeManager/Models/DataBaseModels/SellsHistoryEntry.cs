using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Models.DataBaseModels
{
    [Table("history")]
    class SellsHistoryEntry
    {
        [Key]
        public int idhistory { get; set; }
        public int buyer { get; set; }
        public int price { get; set; }
        public string date { get; set; }
        public string recipe { get; set; }
        public int weigth { get; set; }
    }
}
