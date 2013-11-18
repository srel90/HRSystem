using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comSalary
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comSalary()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) salaryID+1  as lastID FROM salary ORDER BY salaryID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) salaryID+1  as lastID FROM salary ORDER BY salaryID DESC";

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
        public DataSet selectAllSalary()
        {

            try
            {
                str = "SELECT * FROM salary;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllSalaryByPersonalID(int personalID)
        {

            try
            {
                str = "SELECT * FROM salary WHERE personalID=@personalID;";
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

        public DataSet searchSalary(string search)
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
        public Boolean insertSalary(enSalary enSalary)
        {
            try
            {
                str = "INSERT INTO salary (";
                str += "personalID,";
                str += "bank,";
                str += "accountNumber,";
                str += "calculateType,";
                str += "salary,";
                str += "shiftSalary,";
                str += "calTax,";
                str += "calSocialTax,";
                str += "lateDeduct,";
                str += "leaveDeduct";
                str += ")VALUES(";
                str += "@personalID,";
                str += "@bank,";
                str += "@accountNumber,";
                str += "@calculateType,";
                str += "@salary,";
                str += "@shiftSalary,";
                str += "@calTax,";
                str += "@calSocialTax,";
                str += "@lateDeduct,";
                str += "@leaveDeduct";
                str += ");";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enSalary.personalID);
                db.AddInParameter(Dbcmd, "@bank", DbType.String, enSalary.bank);
                db.AddInParameter(Dbcmd, "@accountNumber", DbType.String, enSalary.accountNumber);
                db.AddInParameter(Dbcmd, "@calculateType", DbType.Int32, enSalary.calculateType);
                db.AddInParameter(Dbcmd, "@salary", DbType.Double, enSalary.salary);
                db.AddInParameter(Dbcmd, "@shiftSalary", DbType.Double, enSalary.shiftSalary);
                db.AddInParameter(Dbcmd, "@calTax", DbType.String, enSalary.calTax);
                db.AddInParameter(Dbcmd, "@calSocialTax", DbType.String, enSalary.calSocialTax);
                db.AddInParameter(Dbcmd, "@lateDeduct", DbType.Int32, enSalary.lateDeduct);
                db.AddInParameter(Dbcmd, "@leaveDeduct", DbType.Int32, enSalary.leaveDeduct);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateSalary(enSalary enSalary)
        {
            try
            {
                str = "UPDATE salary SET ";
                str += "personalID=@personalID,";
                str += "bank=@bank,";
                str += "accountNumber=@accountNumber,";
                str += "calculateType=@calculateType,";
                str += "salary=@salary,";
                str += "shiftSalary=@shiftSalary,";
                str += "calTax=@calTax,";
                str += "calSocialTax=@calSocialTax,";
                str += "lateDeduct=@lateDeduct,";
                str += "leaveDeduct=@leaveDeduct";
                str += " WHERE salaryID=@salaryID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enSalary.personalID);
                db.AddInParameter(Dbcmd, "@bank", DbType.String, enSalary.bank);
                db.AddInParameter(Dbcmd, "@accountNumber", DbType.String, enSalary.accountNumber);
                db.AddInParameter(Dbcmd, "@calculateType", DbType.Int32, enSalary.calculateType);
                db.AddInParameter(Dbcmd, "@salary", DbType.Double, enSalary.salary);
                db.AddInParameter(Dbcmd, "@shiftSalary", DbType.Double, enSalary.shiftSalary);
                db.AddInParameter(Dbcmd, "@calTax", DbType.String, enSalary.calTax);
                db.AddInParameter(Dbcmd, "@calSocialTax", DbType.String, enSalary.calSocialTax);
                db.AddInParameter(Dbcmd, "@lateDeduct", DbType.Int32, enSalary.lateDeduct);
                db.AddInParameter(Dbcmd, "@leaveDeduct", DbType.Int32, enSalary.leaveDeduct);
                db.AddInParameter(Dbcmd, "@salaryID", DbType.Int32, enSalary.salaryID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteSalaryBySalaryID(int salaryID)
        {
            try
            {
                str = "DELETE FROM salary WHERE salaryID=@salaryID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@salaryID", DbType.Int32, salaryID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteSalaryByPersonalID(int personalID)
        {
            try
            {
                str = "DELETE FROM salary WHERE personalID=@personalID;";
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
