using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comPayment
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comPayment()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        
        public DataSet selectAllPaymentByPersonalID(int personalID)
        {

            try
            {
                str = "SELECT * FROM payment WHERE personalID=@personalID";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, personalID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllPaymentByPersonalIDAndstartDateendDate(int personalID, string startDate, string endDate)
        {

            try
            {
                str = "SELECT * FROM payment WHERE personalID=@personalID AND datediff(d,startDate,@startDate)=0 AND datediff(d,endDate,@endDate)=0 order by payDate desc";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, personalID);
                db.AddInParameter(Dbcmd, "@startDate", DbType.String, startDate);
                db.AddInParameter(Dbcmd, "@endDate", DbType.String, endDate);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean insertPayment(enPayment enPayment)
        {
            try
            {
                str = "INSERT INTO payment (personalID,startDate,endDate,payDate,expenditureInc,expenditureDec,leaveDec,lateDec,OTInc,socialTaxDec,taxDec,total,salary)";
                str += "VALUES";
                str += "(@personalID,@startDate,@endDate,@payDate,@expenditureInc,@expenditureDec,@leaveDec,@lateDec,@OTInc,@socialTaxDec,@taxDec,@total,@salary);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enPayment.personalID);
                db.AddInParameter(Dbcmd, "@startDate", DbType.String, enPayment.startDate);
                db.AddInParameter(Dbcmd, "@endDate", DbType.String, enPayment.endDate);
                db.AddInParameter(Dbcmd, "@payDate", DbType.String, enPayment.payDate);
                db.AddInParameter(Dbcmd, "@expenditureInc", DbType.Double, enPayment.expenditureInc);
                db.AddInParameter(Dbcmd, "@expenditureDec", DbType.Double, enPayment.expenditureDec);
                db.AddInParameter(Dbcmd, "@leaveDec", DbType.Double, enPayment.leaveDec);
                db.AddInParameter(Dbcmd, "@lateDec", DbType.Double, enPayment.lateDec);
                db.AddInParameter(Dbcmd, "@OTInc", DbType.Double, enPayment.OTInc);
                db.AddInParameter(Dbcmd, "@socialTaxDec", DbType.Double, enPayment.socialTaxDec);
                db.AddInParameter(Dbcmd, "@taxDec", DbType.Double, enPayment.taxDec);
                db.AddInParameter(Dbcmd, "@total", DbType.Double, enPayment.total);
                db.AddInParameter(Dbcmd, "@salary", DbType.Double, enPayment.salary);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
