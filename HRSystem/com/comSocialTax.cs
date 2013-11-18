using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comSocialTax
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comSocialTax()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) socialTaxID+1  as lastID FROM socialTax ORDER BY socialTaxID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) socialTaxID+1  as lastID FROM socialTax ORDER BY socialTaxID DESC";

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
        public DataSet selectAllSocialTax()
        {

            try
            {
                str = "SELECT * FROM socialTax;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet selectAllSocialTaxByPersonalID(int personalID)
        {

            try
            {
                str = "SELECT * FROM socialTax WHERE personalID=@personalID;";
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

        public DataSet searchSocialTax(string search)
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
        public Boolean insertSocialTax(enSocialTax enSocialTax)
        {
            try
            {
                str = "INSERT INTO socialTax (";
                str += "personalID,";
                str += "socialTaxIDCard,";
                str += "hospitalCode,";
                str += "hospital";
                str += ")VALUES(";
                str += "@personalID,";
                str += "@socialTaxIDCard,";
                str += "@hospitalCode,";
                str += "@hospital";
                str += ");";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enSocialTax.personalID);
                db.AddInParameter(Dbcmd, "@socialTaxIDCard", DbType.String, enSocialTax.socialTaxIDCard);
                db.AddInParameter(Dbcmd, "@hospitalCode", DbType.String, enSocialTax.hospitalCode);
                db.AddInParameter(Dbcmd, "@hospital", DbType.String, enSocialTax.hospital);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updateSocialTax(enSocialTax enSocialTax)
        {
            try
            {
                str = "UPDATE socialTax SET ";
                str += "personalID=@personalID,";
                str += "socialTaxIDCard=@socialTaxIDCard,";
                str += "hospitalCode=@hospitalCode,";
                str += "hospital=@hospital";
                str += " WHERE socialTaxID=@socialTaxID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enSocialTax.personalID);
                db.AddInParameter(Dbcmd, "@socialTaxIDCard", DbType.String, enSocialTax.socialTaxIDCard);
                db.AddInParameter(Dbcmd, "@hospitalCode", DbType.String, enSocialTax.hospitalCode);
                db.AddInParameter(Dbcmd, "@hospital", DbType.String, enSocialTax.hospital);
                db.AddInParameter(Dbcmd, "@socialTaxID", DbType.Int32, enSocialTax.socialTaxID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteSocialTaxBySocialTaxID(int socialTaxID)
        {
            try
            {
                str = "DELETE FROM socialTax WHERE socialTaxID=@socialTaxID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@socialTaxID", DbType.Int32, socialTaxID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deleteSocialTaxByPersonalID(int personalID)
        {
            try
            {
                str = "DELETE FROM socialTax WHERE personalID=@personalID;";
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
