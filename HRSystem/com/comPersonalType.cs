using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comPersonalType
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comPersonalType()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) personalTypeID+1  as lastID FROM personalType ORDER BY personalTypeID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) personalTypeID+1  as lastID FROM personalType ORDER BY personalTypeID DESC";

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
        public DataSet selectAllPersonalType()
        {

            try
            {
                str = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  FROM personalType;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchPersonalType(string search)
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
        public Boolean insertPersonalType(enPersonalType enPersonalType)
        {
            try
            {
                str = "INSERT INTO personalType (personalType,status)VALUES(@personalType,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalType", DbType.String, enPersonalType.personalType);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enPersonalType.status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updatePersonalType(enPersonalType enPersonalType)
        {
            try
            {
                str = "UPDATE personalType SET personalType=@personalType, status=@status WHERE personalTypeID=@personalTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalType", DbType.String, enPersonalType.personalType);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enPersonalType.status);
                db.AddInParameter(Dbcmd, "@personalTypeID", DbType.Int32, enPersonalType.personalTypeID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deletePersonalType(int personalTypeID)
        {
            try
            {
                str = "DELETE FROM personalType WHERE personalTypeID=@personalTypeID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalTypeID", DbType.Int32, personalTypeID);
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
