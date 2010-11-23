using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Common;
using ShoppingCard.Object;
using ShoppingCart.Common.DatabaseTableAdapters;
using System.Data.SqlClient;

namespace ShoppingCart.DataAccess
{
    public class UserDAO : ParentDAO
    {

        UserStatusRoleTableAdapter useradapter;
        public UserDAO()
        {
            
           useradapter = new UserStatusRoleTableAdapter();

        }
        public Database.UserStatusRoleDataTable GetAllUser()
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            useradapter.Fill(table);
            return table;
        }
        public Database.UserStatusRoleDataTable GetAllEmployee()
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();

            string sql = "SELECT * FROM UserStatusRole WHERE RoleID  = " + Constant.ROLEID_EMPLOYEE.ToString();
            this.Fill(sql, table);
            return (Database.UserStatusRoleDataTable)table;
        }

        public User GetUserById(int id)
        {
            Database.UserStatusRoleDataTable table = this.GetAllUser();
            User userobject = new User();
            Role roleobject = new Role();
            foreach (Database.UserStatusRoleRow thisrow in table.Rows)
            {
                if (thisrow.UserId == id)
                {
                    userobject.UserId = thisrow.UserId;
                    userobject.UserName = thisrow.Username;
                    userobject.Password = thisrow.Password;
                    userobject.Fullname = thisrow.Fullname;
                    userobject.Address = thisrow.Address;
                    userobject.Email = thisrow.Email;
                    userobject.Gender = thisrow.Gender;
                    userobject.PhoneNumber = thisrow.PhoneNumber;
                    userobject.UserRole.RoleName = (thisrow.RoleName);
                    userobject.StatusUser.StatusName = thisrow.StatusUserName;
                }

            }
            return userobject;
        }

        public Boolean AddUser(User userobject)
        {
            string sql = "INSERT INTO [User](Username,Password,Fullname,Address,Email,Gender,RoleId,PhoneNumber,StatusId)" +
                    " VALUES (@username, @password, @fullname, @address, @email, @gender, @roleid, @phonenumber, @statusid)";
            SqlParameter[] paras = new SqlParameter[9];
            paras[0] = new SqlParameter("@username", userobject.UserName);
            paras[1] = new SqlParameter("@password", userobject.Password);
            paras[2] = new SqlParameter("@fullname", userobject.Fullname);
            paras[3] = new SqlParameter("@address", userobject.Address);
            paras[4] = new SqlParameter("@email", userobject.Email);
            paras[5] = new SqlParameter("@gender", userobject.Gender);
            paras[6] = new SqlParameter("@roleid", userobject.UserRole.RoleId);
            paras[7] = new SqlParameter("@phonenumber", userobject.PhoneNumber);
            paras[8] = new SqlParameter("@statusid", userobject.StatusUser.StatusId);

            return this.ExecuteNonQuery(sql, paras);
        }

        public Boolean EditUser(User userobject)
        {

            string sql = "UPDATE [User] " +
            "SET Username=@Username,Fullname=@Fullname,Address=@Address,Email=@Email,RoleID=@RoleId,StatusId=@StatusId,Gender=@Gender,PhoneNumber=@PhoneNumber "
            + "WHERE UserId=@Userid";
            SqlParameter[] paras = new SqlParameter[9];
            paras[0] = new SqlParameter("@Username", userobject.UserName);
            paras[1] = new SqlParameter("@Fullname", userobject.Fullname);
            paras[2] = new SqlParameter("@Address", userobject.Address);
            paras[3] = new SqlParameter("@Email", userobject.Email);
            paras[4] = new SqlParameter("@Gender", userobject.Gender);
            paras[5] = new SqlParameter("@RoleId", userobject.UserRole.RoleId);
            paras[6] = new SqlParameter("@PhoneNumber", userobject.PhoneNumber);
            paras[7] = new SqlParameter("@StatusId", userobject.StatusUser.StatusId);
            paras[8] = new SqlParameter("@Userid", userobject.UserId);

            return this.ExecuteNonQuery(sql, paras);
        }

        public Boolean DeleteEmployee(int userid)
        {
            string sql = "DELETE [User] WHERE UserId = @Userid";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Userid", userid);
            return this.ExecuteNonQuery(sql, paras);
        }


        public Database.UserStatusRoleDataTable GetUserByUsername(string username)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Username like '%" + username + "%'  AND RoleID  = " + Constant.ROLEID_EMPLOYEE.ToString();
            this.Fill(sql, table);
            return table;
        }

        public Database.UserStatusRoleDataTable GetUserByFullname(string fullname)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Fullname like '%" + fullname + "%'  AND RoleID  = " + Constant.ROLEID_EMPLOYEE.ToString();
            this.Fill(sql, table);
            return table;
        }
        
    }
}
