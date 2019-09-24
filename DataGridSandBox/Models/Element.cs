using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridSandBox.Models
{
    public class Element
    {
        public int Id { get; set; }
        public bool IdHasError { get; set; }
        public string IdErrorMessage { get; set; }
        public double Order { get; set; }
        public bool OrderHasError { get; set; }
        public string OrderErrorMessage { get; set; }
        public string Description1 { get; set; }
        public bool Description1HasError { get; set; }
        public string Description1ErrorMessage { get; set; }
        public string Description2 { get; set; }
        public bool Description2HasError { get; set; }
        public string Description2ErrorMessage { get; set; }


        public string ElementErrorMessage { get; set; }
    }
}
