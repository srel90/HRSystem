using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comPersonal
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comPersonal()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) personalID+1  as lastID FROM personal ORDER BY personalID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) personalID+1  as lastID FROM personal ORDER BY personalID DESC";
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
        public DataSet selectAllPersonal()
        {

            try
            {
                str = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  from personal;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectPersonal(int personalID)
        {

            try
            {
                str = "SELECT *,CASE p.status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  from personal p ";
                str += "left outer join personalAddress pa on p.personalID=pa.personalID ";
                str += "left outer join work w on p.personalID=w.personalID ";
                str += "left outer join party pr on w.partyID=pr.partyID ";
                str += "left outer join department d on w.departmentID=d.departmentID ";
                str += "left outer join position ps on w.positionID=ps.position ";
                str += "left outer join personalType pt on w.personalTypeID=pt.personalTypeID ";
                str += "left outer join salary sa on p.personalID=sa.personalID ";
                str += "left outer join socialTax so on p.personalID=so.personalID where p.personalID="+personalID;
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet selectPersonalList()
        {

            try
            {
                str = "SELECT *,CASE p.status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName  from personal p ";
                str += "left outer join personalAddress pa on p.personalID=pa.personalID ";
                str += "left outer join work w on p.personalID=w.personalID ";
                str += "left outer join party pr on w.partyID=pr.partyID ";
                str += "left outer join department d on w.departmentID=d.departmentID ";
                str += "left outer join position ps on w.positionID=ps.position ";
                str += "left outer join personalType pt on w.personalTypeID=pt.personalTypeID ";
                str += "left outer join salary sa on p.personalID=sa.personalID ";
                str += "left outer join socialTax so on p.personalID=so.personalID;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet searchPersonal(string search)
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
        public Boolean insertPersonal(enPersonal enPersonal)
        {
            try
            {
                str = "INSERT INTO personal (";
                str += "personalID,";
                str += "personalCode,";
                str += "personalCard,";
                str += "title,";
                str += "name,";
                str += "lastname,";
                str += "nickname,";
                str += "sex,";
                str += "height,";
                str += "[weight],";
                str += "bloodGroup,";
                str += "[national],";
                str += "nationality,";
                str += "religion,";
                str += "personalStatus,";
                str += "birthdate,";
                str += "militaryStatus,";
                str += "photo,";
                str += "[status]";
                str += ")VALUES(";
                str += "@personalID,";
                str += "@personalCode,";
                str += "@personalCard,";
                str += "@title,";
                str += "@name,";
                str += "@lastname,";
                str += "@nickname,";
                str += "@sex,";
                str += "@height,";
                str += "@weight,";
                str += "@bloodGroup,";
                str += "@national,";
                str += "@nationality,";
                str += "@religion,";
                str += "@personalStatus,";
                str += "@birthdate,";
                str += "@militaryStatus,";
                str += "@photo,";
                str += "@status";
                str += ");";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enPersonal.personalID);
                db.AddInParameter(Dbcmd, "@personalCode", DbType.String, enPersonal.personalCode);
                db.AddInParameter(Dbcmd, "@personalCard", DbType.String, enPersonal.personalCard);
                db.AddInParameter(Dbcmd, "@title", DbType.String, enPersonal.title);
                db.AddInParameter(Dbcmd, "@name", DbType.String, enPersonal.name);
                db.AddInParameter(Dbcmd, "@lastname", DbType.String, enPersonal.lastname);
                db.AddInParameter(Dbcmd, "@nickname", DbType.String, enPersonal.nickname);
                db.AddInParameter(Dbcmd, "@sex", DbType.String, enPersonal.sex);
                db.AddInParameter(Dbcmd, "@height", DbType.Double, enPersonal.height);
                db.AddInParameter(Dbcmd, "@weight", DbType.Double, enPersonal.weight);
                db.AddInParameter(Dbcmd, "@bloodGroup", DbType.String, enPersonal.bloodGroup);
                db.AddInParameter(Dbcmd, "@national", DbType.String, enPersonal.national);
                db.AddInParameter(Dbcmd, "@nationality", DbType.String, enPersonal.nationality);
                db.AddInParameter(Dbcmd, "@religion", DbType.String, enPersonal.religion);
                db.AddInParameter(Dbcmd, "@personalStatus", DbType.String, enPersonal.personalStatus);
                db.AddInParameter(Dbcmd, "@birthdate", DbType.DateTime, enPersonal.birthdate);
                db.AddInParameter(Dbcmd, "@militaryStatus", DbType.String, enPersonal.militaryStatus);
                db.AddInParameter(Dbcmd, "@photo", DbType.String, enPersonal.photo);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enPersonal.status);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updatePersonal(enPersonal enPersonal)
        {
            try
            {
                str = "UPDATE personal SET ";
                str += "personalCode=@personalCode,";
                str += "personalCard=@personalCard,";
                str += "title=@title,";
                str += "name=@name,";
                str += "lastname=@lastname,";
                str += "nickname=@nickname,";
                str += "sex=@sex,";
                str += "height=@height,";
                str += "[weight]=@weight,";
                str += "bloodGroup=@bloodGroup,";
                str += "[national]=@national,";
                str += "nationality=@nationality,";
                str += "religion=@religion,";
                str += "personalStatus=@personalStatus,";
                str += "birthdate=@birthdate,";
                str += "militaryStatus=@militaryStatus,";
                str += "photo=@photo,";
                str += "[status]=@status";
                str += " WHERE ";
                str += "personalID=@personalID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalCode", DbType.String, enPersonal.personalCode);
                db.AddInParameter(Dbcmd, "@personalCard", DbType.String, enPersonal.personalCard);
                db.AddInParameter(Dbcmd, "@title", DbType.String, enPersonal.title);
                db.AddInParameter(Dbcmd, "@name", DbType.String, enPersonal.name);
                db.AddInParameter(Dbcmd, "@lastname", DbType.String, enPersonal.lastname);
                db.AddInParameter(Dbcmd, "@nickname", DbType.String, enPersonal.nickname);
                db.AddInParameter(Dbcmd, "@sex", DbType.Int32, enPersonal.sex);
                db.AddInParameter(Dbcmd, "@height", DbType.Double, enPersonal.height);
                db.AddInParameter(Dbcmd, "@weight", DbType.Double, enPersonal.weight);
                db.AddInParameter(Dbcmd, "@bloodGroup", DbType.String, enPersonal.bloodGroup);
                db.AddInParameter(Dbcmd, "@national", DbType.String, enPersonal.national);
                db.AddInParameter(Dbcmd, "@nationality", DbType.String, enPersonal.nationality);
                db.AddInParameter(Dbcmd, "@religion", DbType.String, enPersonal.religion);
                db.AddInParameter(Dbcmd, "@personalStatus", DbType.Int32, enPersonal.personalStatus);
                db.AddInParameter(Dbcmd, "@birthdate", DbType.DateTime, enPersonal.birthdate);
                db.AddInParameter(Dbcmd, "@militaryStatus", DbType.Int32, enPersonal.militaryStatus);
                db.AddInParameter(Dbcmd, "@photo", DbType.String, enPersonal.photo);
                db.AddInParameter(Dbcmd, "@status", DbType.Int32, enPersonal.status);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enPersonal.personalID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deletePersonal(int personalID)
        {
            try
            {
                str = "DELETE FROM personal WHERE personalID=@personalID;";
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
