using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Medicine
    {
        public int Id
            {
            get; set;
            }
        public string Name
            {
            get; set;
            }
        public int Price
            {
            get; set;
            }
        public string Category
            {
            get; set;
            }
        public string ManufacturingCompany
            {
            get; set;
            }
        public DateTime ExpiryDate
            {
            get; set;
            }
        }
}
