using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProectWindowsFormsApp1.Model
{
    public class Product
    { 
        public int ID {get; set; }
        public string ProductCode { get; set; }
        public string ProductName {  get; set; }
        public int ReorderLevel {get; set; }
        public string ProductDescription {  get; set; } 
        public int CateogoryID {get; set; }
    }
}
