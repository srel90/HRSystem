using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comUser
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comUser()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public string checkUser(enUser enUser)
        {

            try
            {
                str = "SELECT * FROM users WHERE username=@username AND password=@password AND status=1;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@username", DbType.String, enUser.username);
                db.AddInParameter(Dbcmd, "@password", DbType.String, enUser.password);
                dt = db.ExecuteDataSet(Dbcmd).Tables[0];
                if (dt.Rows.Count != 0)
                {
                    return dt.Rows[0]["userID"].ToString();
                }
                else
                {
                    return "false";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) userID+1  as lastID FROM users ORDER BY userID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) userID+1  as lastID FROM users ORDER BY userID DESC";

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
        public DataSet selectAllUser()
        {

            try
            {
                str = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  FROM users;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectUserByuserID(int userID)
        {

            try
            {
                str = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  FROM users WHERE userID=@userID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@userID", DbType.Int32, userID);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchUser(string search)
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
        public Boolean insertUser(enUser enUser)
        {
            try
            {
                str = "INSERT INTO users (name,lastname,username,password,status)VALUES(@name,@lastname,@username,@password,@status);";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@name", DbType.String, enUser.name);
                db.AddInParameter(Dbcmd, "@lastname", DbType.String, enUser.lastname);
                db.AddInParameter(Dbcmd, "@username", DbType.String, enUser.username);
                db.AddInParameter(Dbcmd, "@password", DbType.String, enUser.password);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enUser.status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateUser(enUser enUser)
        {
            try
            {
                str = "UPDATE users SET name=@name,lastname=@lastname,username=@username,password=@password,status=@status WHERE userID=@userID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@name", DbType.String, enUser.name);
                db.AddInParameter(Dbcmd, "@lastname", DbType.String, enUser.lastname);
                db.AddInParameter(Dbcmd, "@username", DbType.String, enUser.username);
                db.AddInParameter(Dbcmd, "@password", DbType.String, enUser.password);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enUser.status);
                db.AddInParameter(Dbcmd, "@userID", DbType.Int32, enUser.userID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteUser(int userID)
        {
            try
            {
                str = "DELETE FROM users WHERE userID=@userID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@userID", DbType.Int32, userID);
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
