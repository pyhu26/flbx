using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
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

        [JsonPropertyName("LOTID")]
        public string Id { get; set; }
        [JsonPropertyName("LOTNAME")]
        public string Name { get; set; }
        [JsonPropertyName("QTY")]
        public double Qty { get; set; }
        [JsonPropertyName("PROCESSDEFINITIONID")]
        public string ProcessDefinitionId { get; set; }
        [JsonPropertyName("PRODUCTDEFINITIONID")]
        public string ProductDefinitionId { get; set; }
        [JsonPropertyName("PROCESSSEGMENTID")]
        public string Segment { get; set; }
        [JsonPropertyName("EQUIPMENTID")]
        public string Equitment { get; set; }
        [JsonPropertyName("WORKORDERID")]
        public string WorkorderId { get; set; }
        
        public string Remark { get; set; }
        [JsonPropertyName("DESCRIPTION")]
        public string Description { get; set; }

    }
}

