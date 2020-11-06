using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        private int iD;
        private int idBill;
        private int idFood;
        private int count;
        public BillInfo(int id, int idbill, int idfood, int count)
        {
            this.iD = id;
            this.idBill = idbill;
            this.idFood = idfood;
            this.count = count;
        }
        public BillInfo(DataRow row)
        {
            this.iD = (int)row["id"];
            this.idBill = (int)row["idbill"];
            this.idFood = (int)row["idfood"];
            this.count = (int)row["count"];
        }

        public int ID { get => iD; set => iD = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
