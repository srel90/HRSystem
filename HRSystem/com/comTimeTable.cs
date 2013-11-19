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
                str = "select * from timetable where personalCard between @personalCardFrom and @personalCardTo and DATEDIFF(DAY,dateTime,@dateFrom)<=0 and DATEDIFF(DAY,dateTime,@dateTo)>=0";
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
                str = "INSERT INTO timetable (personalCard,dateTime,timeStamp)VALUES(@personalCard,@dateTime,@timeStamp);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalCard", DbType.String, enTimeTable.personalCard);
                db.AddInParameter(Dbcmd, "@dateTime", DbType.String, enTimeTable.dateTime);
                db.AddInParameter(Dbcmd, "@timeStamp", DbType.String, enTimeTable.timeStamp);
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
