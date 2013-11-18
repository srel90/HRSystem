using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comPromoted
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comPromoted()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) promotedID+1  as lastID FROM promoted ORDER BY promotedID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) promotedID+1  as lastID FROM promoted ORDER BY promotedID DESC";

            try
            {

                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllPromoted()
        {

            try
            {
                str = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  FROM promoted;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet selectAllPromotedBypersonalID(int personalID)
        {

            try
            {
                str = "SELECT *  FROM promoted WHERE personalID=@personalID;";
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

        public DataSet searchPromoted(string search)
        {

            try
            {
                Dbcmd = db.GetSqlStringCommand(search);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean insertPromoted(enPromoted enPromoted)
        {
            try
            {
                str = "INSERT INTO promoted (personalID,updateDate,oldSalary,newSalary,oldPositionID,oldPositionDetail,newPositionID,newPositionDetail,remark)VALUES(@personalID,@updateDate,@oldSalary,@newSalary,@oldPositionID,@oldPositionDetail,@newPositionID,@newPositionDetail,@remark);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enPromoted.personalID);
                db.AddInParameter(Dbcmd, "@updateDate", DbType.DateTime, enPromoted.updateDate);
                db.AddInParameter(Dbcmd, "@oldSalary", DbType.Double, enPromoted.oldSalary);
                db.AddInParameter(Dbcmd, "@newSalary", DbType.Double, enPromoted.newSalary);
                db.AddInParameter(Dbcmd, "@oldPositionID", DbType.Int32, enPromoted.oldPositionID);
                db.AddInParameter(Dbcmd, "@oldPositionDetail", DbType.String, enPromoted.oldPositionDetail);
                db.AddInParameter(Dbcmd, "@newPositionID", DbType.Int32, enPromoted.newPositionID);
                db.AddInParameter(Dbcmd, "@newPositionDetail", DbType.String, enPromoted.newPositionDetail);
                db.AddInParameter(Dbcmd, "@remark", DbType.String, enPromoted.remark);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updatePromoted(enPromoted enPromoted)
        {
            try
            {
                str = "UPDATE promoted SET personalID=@personalID,updateDate=@updateDate,oldSalary=@oldSalary,newSalary=@newSalary,oldPositionID=@oldPositionID,oldPositionDetail=@oldPositionDetail,newPositionID=@newPositionID,newPositionDetail=@newPositionDetail,remark=@remark WHERE promotedID=@promotedID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enPromoted.personalID);
                db.AddInParameter(Dbcmd, "@updateDate", DbType.DateTime, enPromoted.updateDate);
                db.AddInParameter(Dbcmd, "@oldSalary", DbType.Double, enPromoted.oldSalary);
                db.AddInParameter(Dbcmd, "@newSalary", DbType.Double, enPromoted.newSalary);
                db.AddInParameter(Dbcmd, "@oldPositionID", DbType.Int32, enPromoted.oldPositionID);
                db.AddInParameter(Dbcmd, "@oldPositionDetail", DbType.String, enPromoted.oldPositionDetail);
                db.AddInParameter(Dbcmd, "@newPositionID", DbType.Int32, enPromoted.newPositionID);
                db.AddInParameter(Dbcmd, "@newPositionDetail", DbType.String, enPromoted.newPositionDetail);
                db.AddInParameter(Dbcmd, "@remark", DbType.String, enPromoted.remark);
                db.AddInParameter(Dbcmd, "@promotedID", DbType.Int32, enPromoted.promotedID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deletePromotedByPromotedID(int promotedID)
        {
            try
            {
                str = "DELETE FROM promoted WHERE promotedID=@promotedID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@promotedID", DbType.Int32, promotedID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deletePromotedByPersonalID(int personalID)
        {
            try
            {
                str = "DELETE FROM promoted WHERE personalID=@personalID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, personalID);
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
