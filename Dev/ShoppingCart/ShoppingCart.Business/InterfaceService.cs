using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.DataAccess;
using ShoppingCart.Common;
using ShoppingCard.Object;

namespace ShoppingCart.Business
{
    public class InterfaceService
    {
        UserDAO userdao;
        AdminService adminservice;
        public InterfaceService()
        {
            userdao = new UserDAO();
            adminservice = new AdminService();
        }

        public User Login(String username,String password)
        {
            if (userdao.Login(username, password) == LoginResult.Succeed)
                return adminservice.ViewUserDetail(username);
            else
                return new User();
        }


    }
}
