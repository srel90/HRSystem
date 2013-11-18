using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comPosition
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comPosition()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) positionID+1  as lastID FROM position ORDER BY positionID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) positionID+1  as lastID FROM position ORDER BY positionID DESC";

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
        public DataSet selectAllPosition()
        {

            try
            {
                str = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  FROM position;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchPosition(string search)
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
        public Boolean insertPosition(enPosition enPosition)
        {
            try
            {
                str = "INSERT INTO position (position,status)VALUES(@position,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@position", DbType.String, enPosition.position);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enPosition.status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updatePosition(enPosition enPosition)
        {
            try
            {
                str = "UPDATE position SET position=@position, status=@status WHERE positionID=@positionID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@position", DbType.String, enPosition.position);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enPosition.status);
                db.AddInParameter(Dbcmd, "@positionID", DbType.Int32, enPosition.positionID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deletePosition(int positionID)
        {
            try
            {
                str = "DELETE FROM position WHERE positionID=@positionID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@positionID", DbType.Int32, positionID);
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
