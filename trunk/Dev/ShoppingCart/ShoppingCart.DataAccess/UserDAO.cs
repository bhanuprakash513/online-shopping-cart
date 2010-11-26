using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Common;
using ShoppingCart.Object;
using ShoppingCart.Common.DatabaseTableAdapters;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ShoppingCart.DataAccess
{
    public class UserDAO : ParentDAO
    {

        UserStatusRoleTableAdapter useradapter;

        /// <summary>
        /// Init
        /// </summary>
        public UserDAO()
        {
            
           useradapter = new UserStatusRoleTableAdapter();

        }

        /// <summary>
        /// Get all user 
        /// </summary>
        /// <returns>Database.UserStatusRoleDataTable</returns>
        public Database.UserStatusRoleDataTable GetAllUser()
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            useradapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Get all employee
        /// </summary>
        /// <returns>Database.UserStatusRoleDataTable</returns>
        public Database.UserStatusRoleDataTable GetAllEmployee()
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();

            string sql = "SELECT * FROM UserStatusRole WHERE RoleID  = " + Constant.ROLEID_EMPLOYEE.ToString();
            this.Fill(sql, table);
            return (Database.UserStatusRoleDataTable)table;
        }
        
        /// <summary>
        /// Get User by UserId
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>User</returns>
        public User GetUserByUserId(int id)
        {
            User userobject = new User();
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM [User] WHERE UserId=@UserId";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@UserId", id);
            this.Fill(sql, paras, table);
            if(table.Rows.Count>0)
                User.Mapping(userobject, table.Rows[0]);
            return userobject;
        }

        /// <summary>
        /// Add a user
        /// </summary>
        /// <param name="userobject">User</param>
        /// <returns>Boolean</returns>
        public Boolean AddUser(User userobject)
        {
            string sql = "INSERT INTO [User](Username,Password,Fullname,Address,Email,Gender,RoleId,PhoneNumber,StatusId)" +
                    " VALUES (@username, @password, @fullname, @address, @email, @gender, @roleid, @phonenumber, @statusid)";
            SqlParameter[] paras = new SqlParameter[9];
            paras[0] = new SqlParameter("@username", userobject.UserName.Trim());
            paras[1] = new SqlParameter("@password", userobject.Password.Trim());
            paras[2] = new SqlParameter("@fullname", userobject.Fullname.Trim());
            paras[3] = new SqlParameter("@address", userobject.Address.Trim());
            paras[4] = new SqlParameter("@email", userobject.Email.Trim());
            paras[5] = new SqlParameter("@gender", userobject.Gender.Trim());
            paras[6] = new SqlParameter("@roleid", userobject.UserRole.RoleId);
            paras[7] = new SqlParameter("@phonenumber", userobject.PhoneNumber.Trim());
            paras[8] = new SqlParameter("@statusid", userobject.StatusUser.StatusId);

            return this.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// Edit user
        /// </summary>
        /// <param name="userobject">User</param>
        /// <returns>Boolean</returns>
        public Boolean EditUser(User userobject)
        {

            string sql = "UPDATE [User] " +
            "SET Username=@Username,Fullname=@Fullname,Address=@Address,Email=@Email,StatusId=@StatusId,Gender=@Gender,PhoneNumber=@PhoneNumber "
            + "WHERE UserId=@Userid AND RoleId=@RoleId";
            SqlParameter[] paras = new SqlParameter[9];
            paras[0] = new SqlParameter("@Username", userobject.UserName.Trim());
            paras[1] = new SqlParameter("@Fullname", userobject.Fullname.Trim());
            paras[2] = new SqlParameter("@Address", userobject.Address.Trim());
            paras[3] = new SqlParameter("@Email", userobject.Email.Trim());
            paras[4] = new SqlParameter("@Gender", userobject.Gender.Trim());
            paras[5] = new SqlParameter("@RoleId", userobject.UserRole.RoleId);
            paras[6] = new SqlParameter("@PhoneNumber", userobject.PhoneNumber.Trim());
            paras[7] = new SqlParameter("@StatusId", userobject.StatusUser.StatusId);
            paras[8] = new SqlParameter("@Userid", userobject.UserId);
            
            return this.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="pass">Boolean</param>
        /// <param name="userid">int</param>
        /// <returns>Boolean</returns>
        public Boolean ChangePassword(String pass, int userid)
        {
            string sql = "UPDATE [User] SET Password=@Password  WHERE UserID=@UserId";
            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@UserId", userid);
            paras[1] = new SqlParameter("@Password", pass.Trim());
            return this.ExecuteNonQuery(sql, paras);
        }
        
        /// <summary>
        /// Delete employee
        /// </summary>
        /// <param name="userid">int</param>
        /// <returns>Boolean</returns>
        public Boolean DeleteEmployee(int userid)
        {
            string sql = "DELETE [User] WHERE UserId = @Userid AND RoleId="+Constant.ROLEID_EMPLOYEE;
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Userid", userid);
            return this.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// Get employee by username
        /// </summary>
        /// <param name="username">String</param>
        /// <returns>Database.UserStatusRoleDataTable</returns>
        public Database.UserStatusRoleDataTable GetEmployeeByUsername(String username)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Username like @Username  AND RoleID  = " + Constant.ROLEID_EMPLOYEE.ToString();
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Username", "%" + username + "%");
            this.Fill(sql, paras, table);
            return table;
        }

        /// <summary>
        /// Get user by username
        /// </summary>
        /// <param name="username">String</param>
        /// <returns>User</returns>
        public User GetUserByUsername(String username)
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

        /// <summary>
        /// Get employee by fullname
        /// </summary>
        /// <param name="fullname">String</param>
        /// <returns>Database.UserStatusRoleDataTable</returns>
        public Database.UserStatusRoleDataTable GetEmployeeByFullname(String fullname)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            string sql = "SELECT * FROM UserStatusRole WHERE Fullname like @Fullname  AND RoleID  = " + Constant.ROLEID_EMPLOYEE.ToString();
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Fullname", "%" + fullname + "%");
            this.Fill(sql, table);
            return table;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username">String</param>
        /// <param name="pass">String</param>
        /// <returns>LoginResult</returns>
        public LoginResult Login(String username, String pass)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            String sql = "SELECT * FROM UserStatusRole WHERE Username= @Username AND Password = @Password AND [UserStatusRole].StatusId="+Constant.STATUSID_ACTIVE;
            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@Username", username);
            paras[1] = new SqlParameter("@Password", pass);
            this.Fill(sql, paras, table);
            if (table.Rows.Count > 0)
            {
                return LoginResult.Succeed;
            }
            else
            {
                return LoginResult.Failed;
            }
        }
    
        /// <summary>
        /// Check username exist
        /// </summary>
        /// <param name="username">String</param>
        /// <returns>Result</returns>
        public Result CheckUsernameExist(String username)
        {
            Database.UserStatusRoleDataTable table = new Database.UserStatusRoleDataTable();
            String sql = "SELECT * FROM UserStatusRole WHERE Username= @Username";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Username", username);
            this.Fill(sql, paras,table);
            if (table.Rows.Count > 0)
            {
                return Result.Failed;
            }
            else
            {
                return Result.Succeed;
            }
        }
   
    }
}
