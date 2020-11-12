using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX.Models
{
    public class Lot
    {
        public Lot()
        {

        }
        public Lot(string id, string name, int qty, string segment, string equitment)
        {
            this.Id = id;
            this.Name = name;
            this.Qty = qty;
            this.Segment = segment;
            this.Equitment = equitment;
        }
        public static List<Lot> GetAllRecords()
        {
            List<Lot> LotDetail = new List<Lot>();

            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankIn","Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankOut", "Aging"));
            LotDetail.Add(new Lot("L01", "Assy-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L01", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Ball-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Stem-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Stem-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Stem-1-L03", 20, "TranOut", "Aging"));
            LotDetail.Add(new Lot("L02", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));
            LotDetail.Add(new Lot("L03", "Stem-1-L03", 20, "TrankIn", "Aging"));



            return LotDetail;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int? Qty { get; set; }
        public string Segment { get; set; }
        public string Equitment { get; set; }

    }
}

