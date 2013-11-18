using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HRSystem.entity;
using System;

namespace HRSystem.com
{
    class comPersonalAddress
    {
        private Database db;
        private DbCommand Dbcmd;
        private DataTable dt;
        private DataSet ds;
        private string str;
        public comPersonalAddress()
        {
            DatabaseFactory.ClearDatabaseProviderFactory();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            db = new DatabaseProviderFactory().Create("connString");
        }
        public DataSet getLastID()
        {
            str = "IF (SELECT TOP(1) personalAddressID+1  as lastID FROM personalAddress ORDER BY personalAddressID DESC) IS NULL SELECT 1 as lastID ELSE SELECT TOP(1) personalAddressID+1  as lastID FROM personalAddress ORDER BY personalAddressID DESC";

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
        public DataSet selectAllPersonalAddress()
        {

            try
            {
                str = "SELECT * FROM personalAddress;";
                Dbcmd = db.GetSqlStringCommand(str);
                ds = db.ExecuteDataSet(Dbcmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet selectAllPersonalAddressByPersonalID(int personalID)
        {

            try
            {
                str = "SELECT * FROM personalAddress WHERE personalID=@personalID;";
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
        public DataSet searchPersonalAddress(string search)
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
        public Boolean insertPersonalAddress(enPersonalAddress enPersonalAddress)
        {
            try
            {
                str = "INSERT INTO personalAddress (";
                str += "personalID,";
                str += "building,";
                str += "room,";
                str += "floor,";
                str += "village,";
                str += "number,";
                str += "lanes,";
                str += "[group],";
                str += "road,";
                str += "district,";
                str += "subdistrict,";
                str += "province,";
                str += "postcode,";
                str += "tel,";
                str += "fax,";
                str += "email,";
                str += "website,";
                str += "ERContact,";
                str += "relation,";
                str += "contactNumber";
                str += ")VALUES(";
                str += "@personalID,";
                str += "@building,";
                str += "@room,";
                str += "@floor,";
                str += "@village,";
                str += "@number,";
                str += "@lanes,";
                str += "@group,";
                str += "@road,";
                str += "@district,";
                str += "@subdistrict,";
                str += "@province,";
                str += "@postcode,";
                str += "@tel,";
                str += "@fax,";
                str += "@email,";
                str += "@website,";
                str += "@ERContact,";
                str += "@relation,";
                str += "@contactNumber";
                str += ");";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enPersonalAddress.personalID);
                db.AddInParameter(Dbcmd, "@building", DbType.String, enPersonalAddress.building);
                db.AddInParameter(Dbcmd, "@room", DbType.String, enPersonalAddress.room);
                db.AddInParameter(Dbcmd, "@floor", DbType.String, enPersonalAddress.floor);
                db.AddInParameter(Dbcmd, "@village", DbType.String, enPersonalAddress.village);
                db.AddInParameter(Dbcmd, "@number", DbType.String, enPersonalAddress.number);
                db.AddInParameter(Dbcmd, "@lanes", DbType.String, enPersonalAddress.lanes);
                db.AddInParameter(Dbcmd, "@group", DbType.String, enPersonalAddress.group);
                db.AddInParameter(Dbcmd, "@road", DbType.String, enPersonalAddress.road);
                db.AddInParameter(Dbcmd, "@district", DbType.String, enPersonalAddress.district);
                db.AddInParameter(Dbcmd, "@subdistrict", DbType.String, enPersonalAddress.subdistrict);
                db.AddInParameter(Dbcmd, "@province", DbType.String, enPersonalAddress.province);
                db.AddInParameter(Dbcmd, "@postcode", DbType.String, enPersonalAddress.postcode);
                db.AddInParameter(Dbcmd, "@tel", DbType.String, enPersonalAddress.tel);
                db.AddInParameter(Dbcmd, "@fax", DbType.String, enPersonalAddress.fax);
                db.AddInParameter(Dbcmd, "@email", DbType.String, enPersonalAddress.email);
                db.AddInParameter(Dbcmd, "@website", DbType.String, enPersonalAddress.website);
                db.AddInParameter(Dbcmd, "@ERContact", DbType.String, enPersonalAddress.ERContact);
                db.AddInParameter(Dbcmd, "@relation", DbType.String, enPersonalAddress.relation);
                db.AddInParameter(Dbcmd, "@contactNumber", DbType.String, enPersonalAddress.contactNumber);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean updatePersonalAddress(enPersonalAddress enPersonalAddress)
        {
            try
            {
                str = "UPDATE personalAddress SET ";
                str += "personalID=@personalID,";
                str += "building=@building,";
                str += "room=@room,";
                str += "floor=@floor,";
                str += "village=@village,";
                str += "number=@number,";
                str += "lanes=@lanes,";
                str += "[group]=@group,";
                str += "road=@road,";
                str += "district=@district,";
                str += "subdistrict=@subdistrict,";
                str += "province=@province,";
                str += "postcode=@postcode,";
                str += "tel=@tel,";
                str += "fax=@fax,";
                str += "email=@email,";
                str += "website=@website,";
                str += "ERContact=@ERContact,";
                str += "relation=@relation,";
                str += "contactNumber=@contactNumber";
                str += " WHERE ";
                str += "personalAddressID=@personalAddressID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalID", DbType.Int32, enPersonalAddress.personalID);
                db.AddInParameter(Dbcmd, "@building", DbType.String, enPersonalAddress.building);
                db.AddInParameter(Dbcmd, "@room", DbType.String, enPersonalAddress.room);
                db.AddInParameter(Dbcmd, "@floor", DbType.String, enPersonalAddress.floor);
                db.AddInParameter(Dbcmd, "@village", DbType.String, enPersonalAddress.village);
                db.AddInParameter(Dbcmd, "@number", DbType.String, enPersonalAddress.number);
                db.AddInParameter(Dbcmd, "@lanes", DbType.String, enPersonalAddress.lanes);
                db.AddInParameter(Dbcmd, "@group", DbType.String, enPersonalAddress.group);
                db.AddInParameter(Dbcmd, "@road", DbType.String, enPersonalAddress.road);
                db.AddInParameter(Dbcmd, "@district", DbType.String, enPersonalAddress.district);
                db.AddInParameter(Dbcmd, "@subdistrict", DbType.String, enPersonalAddress.subdistrict);
                db.AddInParameter(Dbcmd, "@province", DbType.String, enPersonalAddress.province);
                db.AddInParameter(Dbcmd, "@postcode", DbType.String, enPersonalAddress.postcode);
                db.AddInParameter(Dbcmd, "@tel", DbType.String, enPersonalAddress.tel);
                db.AddInParameter(Dbcmd, "@fax", DbType.String, enPersonalAddress.fax);
                db.AddInParameter(Dbcmd, "@email", DbType.String, enPersonalAddress.email);
                db.AddInParameter(Dbcmd, "@website", DbType.String, enPersonalAddress.website);
                db.AddInParameter(Dbcmd, "@ERContact", DbType.String, enPersonalAddress.ERContact);
                db.AddInParameter(Dbcmd, "@relation", DbType.String, enPersonalAddress.relation);
                db.AddInParameter(Dbcmd, "@contactNumber", DbType.String, enPersonalAddress.contactNumber);
                db.AddInParameter(Dbcmd, "@personalAddressID", DbType.Int32, enPersonalAddress.personalAddressID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deletePersonalByPersonalAddressID(int personalAddressID)
        {
            try
            {
                str = "DELETE FROM personalAddress WHERE personalAddressID=@personalAddressID;";
                Dbcmd = db.GetSqlStringCommand(str);
                db.AddInParameter(Dbcmd, "@personalAddressID", DbType.Int32, personalAddressID);
                db.ExecuteNonQuery(Dbcmd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean deletePersonalByPersonalID(int personalID)
        {
            try
            {
                str = "DELETE FROM personalAddress WHERE personalID=@personalID;";
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
