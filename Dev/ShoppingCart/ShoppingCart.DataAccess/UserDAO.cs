using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Common;
using ShoppingCard.Object;
using ShoppingCart.Common.DatabaseTableAdapters;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

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
            User userobject = new User();
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM [User] WHERE UserId=@UserId";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@UserId", id);
            this.Fill(sql, paras, table);
            User.Mapping(userobject, table.Rows[0]);
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

        public Boolean ChangePassword(string pass, int userid)
        {
            string sql = "UPDATE [User] SET Password=@Password  WHERE UserID=@UserId";
            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@UserId", userid);
            paras[1] = new SqlParameter("@Password", pass);
            return this.ExecuteNonQuery(sql, paras);
        }

        public Boolean DeleteEmployee(int userid)
        {
            string sql = "DELETE [User] WHERE UserId = @Userid";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Userid", userid);
            return this.ExecuteNonQuery(sql, paras);
        }


        public Database.UserStatusRoleDataTable GetEmployeeByUsername(string username)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Username like @Username  AND RoleID  = " + Constant.ROLEID_EMPLOYEE.ToString();
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Username", "%" + username + "%");
            this.Fill(sql, paras, table);
            return table;
        }

        public User GetUserByUsername(string username)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Username = @Username";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Username", username);
            this.Fill(sql, paras, table);
            User user = new User();
            if (table.Rows.Count > 0)
                User.Mapping(user, table.Rows[0]);
            return user;
        }

        public Database.UserStatusRoleDataTable GetEmployeeByFullname(string fullname)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Fullname like @Fullname  AND RoleID  = " + Constant.ROLEID_EMPLOYEE.ToString();
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Fullname", "%" + fullname + "%");
            this.Fill(sql, table);
            return table;
        }

        public LoginResult Login(string username, string pass)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Username= @Username AND Password = @Password";
            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@Username", username);
            paras[1] = new SqlParameter("@Password", pass);
            this.Fill(sql, paras, table);
            if (table.Rows.Count > 0)
            {
                return LoginResult.Failed;
            }
            else
            {
                return LoginResult.Succeed;
            }
        }
        public LoginResult CheckStatus(string username, string pass)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Username= @Username AND Password = @Password AND StatusId = " + Constant.STATUS_ACTIVE;
            this.Fill(sql, table);
            if (table.Rows.Count > 0)
            {
                return LoginResult.Failed;
            }
            else
            {
                return LoginResult.Succeed;
            }
        }
        public Result CheckUsernameExist(string username)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Username= @Username";
            SqlParameter[] paras = new SqlParameter[1];
            paras[1] = new SqlParameter("@Username", username);
            this.ExecuteNonQuery(sql, paras);
            if (table.Rows.Count > 0)
            {
                return Result.Failed;
            }
            else
            {
                return Result.Succeed;
            }
        }
        public Result IsValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return Result.Succeed;
            else
                return Result.Failed;
        }
    }
}
