using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.Object
{ 
    public class User
    {
        private int userid;
        private string username;
        private string password;
        private string fullname;
        private string address;
        private string email;
        private string phonenumber;
        private StatusUser statususer;
        private string gender;
        private Role userrole;

        public User()
        {
            statususer = new StatusUser();
            username = "";
            userid = -1;
            password = "";
            fullname = "";
            address = "";
            email = "";
            phonenumber = "";
            gender = "";
            userrole = new Role();
        }

        public int UserId
        {
            get
            {
                return userid;
            }
            set
            {
                userid = value;
            }
        }
        public String UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public String Fullname
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
            }
        }
        public String Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public String PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                phonenumber = value;
            }
        }
        public StatusUser StatusUser
        {
            get 
            {
                return statususer;
            }
            set 
            {
                statususer = value;
            }
        }
        public String Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public virtual Role UserRole
        {
            get
            {
                return userrole;

            }
            set
            {
                userrole = value;
            }
        }


        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="obj">User</param>
        /// <param name="row">DataRow</param>
        public static void Mapping(User obj, DataRow row)
        {
            try
            {
                StatusUser.Mapping(obj.StatusUser, row);
                Role.Mapping(obj.UserRole, row);
                if (row[ColumnName.USER_ADDRESS] != null && row[ColumnName.USER_ADDRESS].ToString()!="")
                    obj.Address = row[ColumnName.USER_ADDRESS].ToString();
                if (row[ColumnName.USER_EMAIL] != null && row[ColumnName.USER_EMAIL].ToString()!="")
                    obj.Email = row[ColumnName.USER_EMAIL].ToString();
                if (row[ColumnName.USER_FULLNAME] != null && row[ColumnName.USER_FULLNAME].ToString()!="")
                    obj.Fullname = row[ColumnName.USER_FULLNAME].ToString();
                if (row[ColumnName.USER_GENDER] != null && row[ColumnName.USER_GENDER].ToString()!="")
                    obj.Gender = row[ColumnName.USER_GENDER].ToString();
                if (row[ColumnName.USER_PHONENUMBER] != null && row[ColumnName.USER_PHONENUMBER].ToString()!="")
                    obj.PhoneNumber = row[ColumnName.USER_PHONENUMBER].ToString();
                if (row[ColumnName.USER_USERID] != null && row[ColumnName.USER_USERID].ToString()!="")
                    obj.UserId = Convert.ToInt32(row[ColumnName.USER_USERID].ToString());
                if (row[ColumnName.USER_USERNAME] != null && row[ColumnName.USER_USERNAME].ToString()!="")
                    obj.UserName = row[ColumnName.USER_USERNAME].ToString();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        /// <summary>
        /// Mapping List
        /// </summary>
        /// <param name="lst">List</param>
        /// <param name="table">DataTable</param>
        public static void Mapping(List<User> lst, DataTable table)
        {
          
            User obj;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                obj = new User();
                Mapping(obj,table.Rows[i]);
                lst.Add(obj);
            }
          
        }

        /// <summary>
        /// Mapping from user to obj
        /// </summary>
        /// <param name="obj">Customer</param>
        /// <param name="user">User</param>
        public static void Mapping(Customer obj, User user)
        {
            obj.UserId = user.userid;
            if (user.UserName != null && user.UserName != "")
                obj.UserName = user.UserName;
            if (user.Address != null && user.Address != "")
                obj.Address = user.Address;
            if (user.Email != null && user.Email != "")
                obj.Email = user.Email;
            if (user.Fullname != null && user.Fullname != "")
                obj.Fullname = user.Fullname;
            if (user.Gender != null && user.Gender != "")
                obj.Gender = user.Gender;
            if (user.Password != null && user.Password != "")
                obj.Password = user.Password;
            if (user.PhoneNumber != null && user.PhoneNumber != "")
                obj.PhoneNumber = user.PhoneNumber;
            obj.StatusUser = user.StatusUser;
        }

        /// <summary>
        /// Mapping from user to employee
        /// </summary>
        /// <param name="obj">Employee</param>
        /// <param name="user">User</param>
        public static void Mapping(Employee obj, User user)
        {
            obj.UserId = user.userid;
            if (user.UserName != null && user.UserName != "")
                obj.UserName = user.UserName;
            if (user.Address != null && user.Address != "")
                obj.Address = user.Address;
            if (user.Email != null && user.Email != "")
                obj.Email = user.Email;
            if (user.Fullname != null && user.Fullname != "")
                obj.Fullname = user.Fullname;
            if (user.Gender != null && user.Gender != "")
                obj.Gender = user.Gender;
            if (user.Password != null && user.Password != "")
                obj.Password = user.Password;
            if (user.PhoneNumber != null && user.PhoneNumber != "")
                obj.PhoneNumber = user.PhoneNumber;
            obj.StatusUser = user.StatusUser;
        }

        /// <summary>
        /// Mapping from obj to user
        /// </summary>
        /// <param name="obj">Admin</param>
        /// <param name="user">User</param>
        public static void Mapping(Admin obj, User user)
        {
            obj.UserId = user.userid;
            if (user.UserName != null && user.UserName != "")
                obj.UserName = user.UserName;
            if (user.Address != null && user.Address != "")
                obj.Address = user.Address;
            if (user.Email != null && user.Email != "")
                obj.Email = user.Email;
            if (user.Fullname != null && user.Fullname != "")
                obj.Fullname = user.Fullname;
            if (user.Gender != null && user.Gender != "")
                obj.Gender = user.Gender;
            if (user.Password != null && user.Password != "")
                obj.Password = user.Password;
            if (user.PhoneNumber != null && user.PhoneNumber != "")
                obj.PhoneNumber = user.PhoneNumber;
            obj.StatusUser = user.StatusUser;
        }
    }
}
