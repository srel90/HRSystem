using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comTimeTable
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comTimeTable()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet selectTimeTable(string personalCardFrom,string personalCardTo,string dateFrom,string dateTo)
        {
            try
            {
                str = "select * from timetable where personalCard between @personalCardFrom and @personalCardTo and DATEDIFF(DAY,timetable,@dateFrom)<=0 and DATEDIFF(DAY,timetable,@dateTo)>=0";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalCardFrom", DbType.String, personalCardFrom);
                db.AddInParameter(Dbcmd, "@personalCardTo", DbType.String, personalCardTo);
                db.AddInParameter(Dbcmd, "@dateFrom", DbType.String, dateFrom);
                db.AddInParameter(Dbcmd, "@dateTo", DbType.String, dateTo);
                return db.ExecuteDataSet(Dbcmd);
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean insertTimeTable(enTimeTable enTimeTable)
        {
            try
            {
                str = "INSERT INTO timetable (personalCard,timetable,onduty,offduty,clockIn,clockOut)VALUES(@personalCard,@timetable,@onduty,@offduty,@clockIn,@clockOut);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalCard", DbType.String, enTimeTable.personalCard);
                db.AddInParameter(Dbcmd, "@timetable", DbType.String, enTimeTable.timetable);
                db.AddInParameter(Dbcmd, "@onduty", DbType.String, enTimeTable.onduty);
                db.AddInParameter(Dbcmd, "@offduty", DbType.String, enTimeTable.offduty);
                db.AddInParameter(Dbcmd, "@clockIn", DbType.String, enTimeTable.clockIn);
                db.AddInParameter(Dbcmd, "@clockOut", DbType.String, enTimeTable.clockOut);
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
