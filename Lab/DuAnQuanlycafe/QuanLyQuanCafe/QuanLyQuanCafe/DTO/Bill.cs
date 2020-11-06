using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int idTable;
        private int status;

        public Bill(int id, DateTime? datecheckin, DateTime? datecheckout,int idtable , int status)
        {
            this.ID = id;
            this.dateCheckIn = datecheckin;
            this.dateCheckOut = datecheckout;
            this.idTable = idtable;
            this.status = status;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            var dateCheckInTemp = row["dateCheckIn"];
            if (dateCheckInTemp.ToString() != "")
                this.DateCheckIn = (DateTime?)dateCheckInTemp;


            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.idTable = (int)row["idtable"];
            this.Status = (int)row["status"];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int Status { get => status; set => status = value; }
    }
}
