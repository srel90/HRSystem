using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comLeaveRight
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comLeaveRight()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) leaveRightID+1  as lastID FROM leaveRight ORDER BY leaveRightID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) leaveRightID+1  as lastID FROM leaveRight ORDER BY leaveRightID DESC";

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
        public DataSet selectAllLeaveRight()
        {

            try
            {
                str = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  FROM leaveRight;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet selectAllLeaveRightByPersonalID(int personalID)
        {

            try
            {
                str = "SELECT *  FROM leaveRight WHERE personalID=@personalID;";
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

        public DataSet searchLeaveRight(string search)
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
        public Boolean insertLeaveRight(enLeaveRight enLeaveRight)
        {
            try
            {
                str = "INSERT INTO leaveRight (personalID,year,description,leaveAmount,usedLeaveAmount,balanceLeaveAmount)VALUES(@personalID,@year,@description,@leaveAmount,@usedLeaveAmount,@balanceLeaveAmount);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enLeaveRight.personalID);
                db.AddInParameter(Dbcmd, "@year", DbType.String, enLeaveRight.year);
                db.AddInParameter(Dbcmd, "@description", DbType.String, enLeaveRight.description);
                db.AddInParameter(Dbcmd, "@leaveAmount", DbType.Int32, enLeaveRight.leaveAmount);
                db.AddInParameter(Dbcmd, "@usedLeaveAmount", DbType.Int32, enLeaveRight.usedLeaveAmount);
                db.AddInParameter(Dbcmd, "@balanceLeaveAmount", DbType.Int32, enLeaveRight.balanceLeaveAmount);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateLeaveRight(enLeaveRight enLeaveRight)
        {
            try
            {
                str = "UPDATE leaveRight SET personalID=@personalID,year=@year,description=@description,leaveAmount=@leaveAmount,usedLeaveAmount=@usedLeaveAmount,balanceLeaveAmount=@balanceLeaveAmount WHERE leaveRightID=@leaveRightID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enLeaveRight.personalID);
                db.AddInParameter(Dbcmd, "@year", DbType.String, enLeaveRight.year);
                db.AddInParameter(Dbcmd, "@description", DbType.String, enLeaveRight.description);
                db.AddInParameter(Dbcmd, "@leaveAmount", DbType.Int32, enLeaveRight.leaveAmount);
                db.AddInParameter(Dbcmd, "@usedLeaveAmount", DbType.Int32, enLeaveRight.usedLeaveAmount);
                db.AddInParameter(Dbcmd, "@balanceLeaveAmount", DbType.Int32, enLeaveRight.balanceLeaveAmount);
                db.AddInParameter(Dbcmd, "@leaveRightID", DbType.Int32, enLeaveRight.leaveRightID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteLeaveRightByleaveRightID(int leaveRightID)
        {
            try
            {
                str = "DELETE FROM leaveRight WHERE leaveRightID=@leaveRightID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@leaveRightID", DbType.Int32, leaveRightID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteLeaveRightBypersonalID(int personalID)
        {
            try
            {
                str = "DELETE FROM leaveRight WHERE personalID=@personalID;";
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
