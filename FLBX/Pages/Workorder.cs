using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX.Pages
{
    public class WorkOrderDetails
    {
        public WorkOrderDetails()
        {

        }
        public WorkOrderDetails( int id, string name, int qty, string product)
        {
            this.Id = id;
            this.WorkOrder = name;
            this.Qty = qty;         
            this.Pruduct = product;
           
        }
        public static List<WorkOrderDetails> GetAllRecords()
        {
            List<WorkOrderDetails> WorkOrder = new List<WorkOrderDetails>();
            WorkOrder.Add(new WorkOrderDetails(11109,"P/O:11101",200,"CBJODFDFDFD"));
            WorkOrder.Add(new WorkOrderDetails(11109, "P/O:11101", 200, "CBJODFDFDFD"));
            WorkOrder.Add(new WorkOrderDetails(11109, "P/O:11102", 200, "CBJODFDFDFD"));
            WorkOrder.Add(new WorkOrderDetails(11109, "P/O:11102", 200, "CBJODFDFDFD"));
            WorkOrder.Add(new WorkOrderDetails(11109, "P/O:11103", 200, "CBJODFDFDFD"));
            WorkOrder.Add(new WorkOrderDetails(11109, "P/O:11103", 200, "CBJODFDFDFD"));
            WorkOrder.Add(new WorkOrderDetails(11109, "P/O:11103", 200, "CBJODFDFDFD"));

            return WorkOrder;
        }
        public int? Id { get; set; }
        public string WorkOrder { get; set; }
        public int? Qty { get; set; }
        public string Pruduct { get; set; }
       
    }
}

