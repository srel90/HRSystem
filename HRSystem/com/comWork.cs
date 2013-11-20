using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comWork
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comWork()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) workID+1  as lastID FROM work ORDER BY workID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) workID+1  as lastID FROM work ORDER BY workID DESC";

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
        public DataSet selectAllWork()
        {

            try
            {
                str = "SELECT * FROM work;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllWorkByPersonalID(int personalID)
        {

            try
            {
                str = "SELECT * FROM work WHERE personalID=@personalID;";
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

        public DataSet searchWork(string search)
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
        public Boolean insertWork(enWork enWork)
        {
            try
            {
                str = "INSERT INTO work (";
                str += "personalID,";
                str += "partyID,";
                str += "departmentID,";
                str += "positionID,";
                str += "personalTypeID,";
                str += "level,";
                str += "workStatus,";
                str += "startDate,";
                str += "resignDate,";
                str += "taxNumber,";
                str += "idCard,";
                str += "issueDate,";
                str += "expireDate,";
                str += "issueAddress,";
                str += "idCardAddress,";
                str += "timein,";
                str += "timeout";
                str += ")VALUES(";
                str += "@personalID,";
                str += "@partyID,";
                str += "@departmentID,";
                str += "@positionID,";
                str += "@personalTypeID,";
                str += "@level,";
                str += "@workStatus,";
                str += "@startDate,";
                str += "@resignDate,";
                str += "@taxNumber,";
                str += "@idCard,";
                str += "@issueDate,";
                str += "@expireDate,";
                str += "@issueAddress,";
                str += "@idCardAddress,";
                str += "@timein,";
                str += "@timeout";
                str += ");";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enWork.personalID);
                db.AddInParameter(Dbcmd, "@partyID", DbType.Int32, enWork.partyID);
                db.AddInParameter(Dbcmd, "@departmentID", DbType.Int32, enWork.departmentID);
                db.AddInParameter(Dbcmd, "@positionID", DbType.Int32, enWork.positionID);
                db.AddInParameter(Dbcmd, "@personalTypeID", DbType.Int32, enWork.personalTypeID);
                db.AddInParameter(Dbcmd, "@level", DbType.String, enWork.level);
                db.AddInParameter(Dbcmd, "@workStatus", DbType.Int32, enWork.workStatus);
                db.AddInParameter(Dbcmd, "@startDate", DbType.DateTime, enWork.startDate);
                db.AddInParameter(Dbcmd, "@resignDate", DbType.DateTime, enWork.resignDate);
                db.AddInParameter(Dbcmd, "@taxNumber", DbType.String, enWork.taxNumber);
                db.AddInParameter(Dbcmd, "@idCard", DbType.String, enWork.idCard);
                db.AddInParameter(Dbcmd, "@issueDate", DbType.DateTime, enWork.issueDate);
                db.AddInParameter(Dbcmd, "@expireDate", DbType.DateTime, enWork.expireDate);
                db.AddInParameter(Dbcmd, "@issueAddress", DbType.String, enWork.issueAddress);
                db.AddInParameter(Dbcmd, "@idCardAddress", DbType.String, enWork.idCardAddress);
                db.AddInParameter(Dbcmd, "@timein", DbType.String, enWork.timein);
                db.AddInParameter(Dbcmd, "@timeout", DbType.String, enWork.timeout);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateWork(enWork enWork)
        {
            try
            {
                str = "UPDATE work SET ";
                str += "personalID=@personalID,";
                str += "partyID=@partyID,";
                str += "departmentID=@departmentID,";
                str += "positionID=@positionID,";
                str += "personalTypeID=@personalTypeID,";
                str += "level=@level,";
                str += "workStatus=@workStatus,";
                str += "startDate=@startDate,";
                str += "resignDate=@resignDate,";
                str += "taxNumber=@taxNumber,";
                str += "idCard=@idCard,";
                str += "issueDate=@issueDate,";
                str += "expireDate=@expireDate,";
                str += "issueAddress=@issueAddress,";
                str += "idCardAddress=@idCardAddress,";
                str += "timein=@timein,";
                str += "timeout=@timeout";
                str += " WHERE workID=@workID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enWork.personalID);
                db.AddInParameter(Dbcmd, "@partyID", DbType.Int32, enWork.partyID);
                db.AddInParameter(Dbcmd, "@departmentID", DbType.Int32, enWork.departmentID);
                db.AddInParameter(Dbcmd, "@positionID", DbType.Int32, enWork.positionID);
                db.AddInParameter(Dbcmd, "@personalTypeID", DbType.Int32, enWork.personalTypeID);
                db.AddInParameter(Dbcmd, "@level", DbType.String, enWork.level);
                db.AddInParameter(Dbcmd, "@workStatus", DbType.Int32, enWork.workStatus);
                db.AddInParameter(Dbcmd, "@startDate", DbType.DateTime, enWork.startDate);
                db.AddInParameter(Dbcmd, "@resignDate", DbType.DateTime, enWork.resignDate);
                db.AddInParameter(Dbcmd, "@taxNumber", DbType.String, enWork.taxNumber);
                db.AddInParameter(Dbcmd, "@idCard", DbType.String, enWork.idCard);
                db.AddInParameter(Dbcmd, "@issueDate", DbType.DateTime, enWork.issueDate);
                db.AddInParameter(Dbcmd, "@expireDate", DbType.DateTime, enWork.expireDate);
                db.AddInParameter(Dbcmd, "@issueAddress", DbType.String, enWork.issueAddress);
                db.AddInParameter(Dbcmd, "@idCardAddress", DbType.String, enWork.idCardAddress);
                db.AddInParameter(Dbcmd, "@timein", DbType.String, enWork.timein);
                db.AddInParameter(Dbcmd, "@timeout", DbType.String, enWork.timeout);
                db.AddInParameter(Dbcmd, "@workID", DbType.Int32, enWork.workID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteWorkByWorkID(int workID)
        {
            try
            {
                str = "DELETE FROM work WHERE workID=@workID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@workID", DbType.Int32, workID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteWorkByPersonalID(int personalID)
        {
            try
            {
                str = "DELETE FROM work WHERE personalID=@personalID;";
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
