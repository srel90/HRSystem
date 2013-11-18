using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comParty
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comParty()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) partyID+1  as lastID FROM party ORDER BY partyID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) partyID+1  as lastID FROM party ORDER BY partyID DESC";

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
        public DataSet selectAllParty()
        {
            
            try
            {
                str = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  FROM party;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchParty(string search)
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
        public Boolean insertParty(enParty enParty)
        {
            try
            {
                str = "INSERT INTO party (name,status)VALUES(@name,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@name", DbType.String, enParty.name);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enParty.status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateParty(enParty enParty)
        {
            try
            {
                str = "UPDATE party SET name=@name, status=@status WHERE partyID=@partyID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@name", DbType.String, enParty.name);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enParty.status);
                db.AddInParameter(Dbcmd, "@partyID", DbType.Int32, enParty.partyID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteParty(int partyID)
        {
            try
            {
                str = "DELETE FROM party WHERE partyID=@partyID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@partyID", DbType.Int32, partyID);
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
