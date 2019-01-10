using System;

namespace BusinessLogic.Models
{
    public class Head
    {
        public int Id { get; set; }

        public DateTime CreateOn { get; set; }

        public int CreateBy { get; set; }

        public DateTime UpdateOn { get; set; }

        public int UpdateBy { get; set; }

        public int WarehouseId { get; set; }

        public int StatusId { get; set; }

        public int DateId { get; set; }
   
    }
}
