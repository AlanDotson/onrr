
CREATE PROCEDURE [Application].[JTRN_SL_DETAILSelectAll]
AS
SET NOCOUNT ON

SELECT jtrnsldetail.SL_DETAIL_NO
    ,jtrnsldetail.OPER_BUS_SEG_CD
    ,jtrnsldetail.ACCTG_MTH
    ,jtrnsldetail.ACCT_NO
    ,jtrnsldetail.TRANS_VAL_AMT
    ,jtrnsldetail.TRANS_QTY
    ,jtrnsldetail.BTU_FACT
    ,jtrnsldetail.GRS_AMT
    ,jtrnsldetail.GRS_QTY
    ,jtrnsldetail.MAJ_PROD_CD
    ,jtrnsldetail.PROD_CD
    ,jtrnsldetail.OWNR_BA_NO
    ,jtrnsldetail.OWNR_INT_DEC
    ,jtrnsldetail.CTR_PTY_NO
    ,jtrnsldetail.PROP_NO
    ,jtrnsldetail.DO_TYPE_CD
    ,jtrnsldetail.DO_MAJ_PROD_CD
    ,jtrnsldetail.TIER
    ,jtrnsldetail.PPN_RSN_CD
    ,jtrnsldetail.PRDN_DT
    ,jtrnsldetail.ST_CD
    ,jtrnsldetail.MMBTU_OWNR_VOL
    ,jtrnsldetail.WELL_NO
    ,jtrnsldetail.COMPL_NO
    ,jtrnadj.ADJ_CTGY_CD
    ,jtrnadj.NET_AMT
    ,jtrnsldetail.DISP_CD
    ,jtrnsldetail.NET_VOL
FROM [dbo].[JTRN_SL_DETAIL] jtrnsldetail
	LEFT JOIN [dbo].[JTRN_SL_DETAIL_ADJ_CTGY] jtrnadj on jtrnsldetail.SL_DETAIL_NO = jtrnadj.SL_DETAIL_NO



