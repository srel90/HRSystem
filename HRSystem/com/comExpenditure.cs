using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comExpenditure
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comExpenditure()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) expenditureID+1  as lastID FROM expenditure ORDER BY expenditureID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) expenditureID+1  as lastID FROM expenditure ORDER BY expenditureID DESC";

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
        public DataSet selectAllExpenditure()
        {

            try
            {
                str = "SELECT * FROM expenditure;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectAllExpenditureByPersonalID(int personalID)
        {

            try
            {
                str = "SELECT * FROM expenditure WHERE personalID=@personalID;";
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

        public DataSet searchExpenditure(string search)
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
        public Boolean insertExpenditure(enExpenditure enExpenditure)
        {
            try
            {
                str = "INSERT INTO expenditure (";
                str += "personalID,";
                str += "expenditureType,";
                str += "description,";
                str += "calTax,";
                str += "calSocialTax,";
                str += "amount";
                str += ")VALUES(";
                str += "@personalID,";
                str += "@expenditureType,";
                str += "@description,";
                str += "@calTax,";
                str += "@calSocialTax,";
                str += "@amount";
                str += ");";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enExpenditure.personalID);
                db.AddInParameter(Dbcmd, "@expenditureType", DbType.Int32, enExpenditure.expenditureType);
                db.AddInParameter(Dbcmd, "@description", DbType.String, enExpenditure.description);
                db.AddInParameter(Dbcmd, "@calTax", DbType.String, enExpenditure.calTax);
                db.AddInParameter(Dbcmd, "@calSocialTax", DbType.String, enExpenditure.calSocialTax);
                db.AddInParameter(Dbcmd, "@amount", DbType.Double, enExpenditure.amount);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateExpenditure(enExpenditure enExpenditure)
        {
            try
            {
                str = "UPDATE expenditure SET ";
                str += "personalID=@personalID,";
                str += "expenditureType=@expenditureType,";
                str += "description=@description,";
                str += "calTax=@calTax,";
                str += "calSocialTax=@calSocialTax,";
                str += "amount=@amount";
                str += " WHERE expenditureID=@expenditureID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enExpenditure.personalID);
                db.AddInParameter(Dbcmd, "@expenditureType", DbType.Int32, enExpenditure.expenditureType);
                db.AddInParameter(Dbcmd, "@description", DbType.String, enExpenditure.description);
                db.AddInParameter(Dbcmd, "@calTax", DbType.String, enExpenditure.calTax);
                db.AddInParameter(Dbcmd, "@calSocialTax", DbType.String, enExpenditure.calSocialTax);
                db.AddInParameter(Dbcmd, "@amount", DbType.Double, enExpenditure.amount);
                db.AddInParameter(Dbcmd, "@expenditureID", DbType.Int32, enExpenditure.expenditureID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteExpenditureByExpenditureID(int expenditureID)
        {
            try
            {
                str = "DELETE FROM expenditure WHERE expenditureID=@expenditureID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@expenditureID", DbType.Int32, expenditureID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteExpenditureBypersonalID(int personalID)
        {
            try
            {
                str = "DELETE FROM expenditure WHERE personalID=@personalID;";
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
