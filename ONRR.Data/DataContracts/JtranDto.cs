using System;
using System.ComponentModel;

namespace QEP.ONRR.Data.DataContracts
{
    public class JtranDto
    {
        [DisplayName("SL Detail No")]
        public long SL_DETAIL_NO { get; set; }

        [DisplayName("Operator Business Segment Code")]
        public string OPER_BUS_SEG_CD { get; set; }

        [DisplayName("Accounting Month")]
        public DateTime ACCTG_MTH { get; set; }

        [DisplayName("Account Number")]
        public string ACCT_NO { get; set; }

        [DisplayName("Transaction Value Amount")]
        public decimal? TRANS_VAL_AMT { get; set; }

        [DisplayName("Transaction Quantity")]
        public decimal? TRANS_QTY { get; set; }

        [DisplayName("BTU Factor")]
        public decimal? BTU_FACT { get; set; }

        [DisplayName("Gross Amount")]
        public decimal? GRS_AMT { get; set; }

        [DisplayName("Gross Quantity")]
        public decimal? GRS_QTY { get; set; }

        [DisplayName("Major Product Code")]
        public string MAJ_PROD_CD { get; set; }

        [DisplayName("Product Code")]
        public string PROD_CD { get; set; }

        [DisplayName("Owner BA Number")]
        public string OWNR_BA_NO { get; set; }

        [DisplayName("Owner Interest")]
        public decimal? OWNR_INT_DEC { get; set; }

        [DisplayName("Counter Priority Number")]
        public string CTR_PTY_NO { get; set; }

        [DisplayName("Property Number")]
        public string PROP_NO { get; set; }

        [DisplayName("DO Type Code")]
        public string DO_TYPE_CD { get; set; }

        [DisplayName("DO Major Product Code")]
        public string DO_MAJ_PROD_CD { get; set; }

        [DisplayName("Tier")]
        public int? TIER { get; set; }

        [DisplayName("PPN Reason Code")]
        public string PPN_RSN_CD { get; set; }

        [DisplayName("Production Date")]
        public DateTime? PRDN_DT { get; set; }

        [DisplayName("State Code")]
        public string ST_CD { get; set; }

        [DisplayName("MMBTO Owner Volume")]
        public decimal? MMBTU_OWNR_VOL { get; set; }

        [DisplayName("Well Number")]
        public string WELL_NO { get; set; }

        [DisplayName("Compliance Number")]
        public string COMPL_NO { get; set; }

        [DisplayName("Adjusted Category Code")]
        public string ADJ_CTGY_CD { get; set; }

        [DisplayName("Net Amount")]
        public decimal NET_AMT { get; set; }

        [DisplayName("Display Code")]
        public string DISP_CD { get; set; }

        [DisplayName("Net Volume")]
        public decimal? NET_VOL { get; set; }

    }
}
