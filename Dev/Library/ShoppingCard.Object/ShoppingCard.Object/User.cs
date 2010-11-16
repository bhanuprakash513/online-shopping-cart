using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{ 
    public class User
    {
        private int userid;
        private string username;
        private string password;
        private string fullname;
        private string address;
        private string email;
        private string phonenumer;
        private StatusUser statususer;
        private string gender;
        private Role userrole;

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
        public String PhoneNumer
        {
            get
            {
                return phonenumer;
            }
            set
            {
                phonenumer = value;
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
        public Role UserRole
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

    }
}
