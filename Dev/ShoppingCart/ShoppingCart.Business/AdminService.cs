using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using ShoppingCart.DataAccess;
using ShoppingCart.Common;

namespace ShoppingCart.Business
{
    public class AdminService
    {
        FeedbackDAO feeddao;
        UnreCustomerService unrecustomerservice;
        UserDAO userdao;
        ProductDAO productdao;
        EmployeeService empservice;

        /// <summary>
        /// Init
        /// </summary>
        public AdminService()
        {
            feeddao = new FeedbackDAO();
            unrecustomerservice = new UnreCustomerService();
            userdao = new UserDAO();
            productdao = new ProductDAO();
            empservice=new EmployeeService();
        }

        /// <summary>
        /// Get all feedback
        /// </summary>
        /// <returns>List</returns>
        public List<Feedback> GetAllFeedback()
        {
            return feeddao.GetAllFeedback();
        }

        /// <summary>
        /// Add faq
        /// </summary>
        /// <param name="faq">Feedback</param>
        /// <returns>Boolean</returns>
        public Boolean AddFAQ(Feedback faq)
        {
            return feeddao.AddFAQ(faq);
        }

        /// <summary>
        /// Get feedbackfaq by feedid
        /// </summary>
        /// <param name="feedid">int</param>
        /// <returns>Feedback</returns>
        public Feedback GetFeedbackFAQByFeedId(int feedid)
        {
            return feeddao.GetFeedbackFAQByFeedId(feedid);
        }

        /// <summary>
        /// Get feedback by userid
        /// </summary>
        /// <param name="userid">int</param>
        /// <returns>List</returns>
        public List<Feedback> GetFeedbackByUserId(int userid)
        {
            return feeddao.GetFeedbackByUserId(userid);
        }

        /// <summary>
        /// Update feedback fao by feedid
        /// </summary>
        /// <param name="feed">Feedback</param>
        /// <returns>Boolean</returns>
        public Boolean UpdateFeedbackFAQByFeedId(Feedback feed)
        {
            return feeddao.UpdateFeedbackFAQByFeedId(feed);
        }

        /// <summary>
        /// Delete feedbackfaq by feeid 
        /// </summary>
        /// <param name="feedid">int</param>
        /// <returns>Boolean</returns>
        public Boolean DeleteFeedbackFAQByFeedId(int feedid)
        {
            return feeddao.DeleteFeedbackFAQByFeedId(feedid);
        }

        /// <summary>
        /// Get all faq
        /// </summary>
        /// <returns>List</returns>
        public List<Feedback> GetAllFAQ()
        {
            return unrecustomerservice.GetAllFAQ();
        }
        
        /// <summary>
        /// Get all employee
        /// </summary>
        /// <returns> Database.UserStatusRoleDataTable</returns>
        public Database.UserStatusRoleDataTable GetAllEmployee()
        {
            return userdao.GetAllEmployee();
        }

        /// <summary>
        /// Edit employee
        /// </summary>
        /// <param name="userobject">Employee</param>
        /// <returns>Boolean</returns>
        public Boolean EditEmployee(Employee userobject)
        {

            return userdao.EditUser(userobject);
        }

        /// <summary>
        /// Delete employee
        /// </summary>
        /// <param name="userid">int</param>
        /// <returns>Boolean</returns>
        public Boolean DeleteEmployee(int userid)
        {
            return userdao.DeleteEmployee(userid);
        }

        /// <summary>
        /// Get employee by username
        /// </summary>
        /// <param name="username">String</param>
        /// <returns>Database.UserStatusRoleDataTable</returns>
        public Database.UserStatusRoleDataTable GetEmployeeByUsername(String username)
        {
            return userdao.GetEmployeeByUsername(username);
        }

        /// <summary>
        /// Get employee by fullname
        /// </summary>
        /// <param name="fullname">String</param>
        /// <returns>Database.UserStatusRoleDataTable</returns>
        public Database.UserStatusRoleDataTable GetEmployeeByFullname(String fullname)
        {
            return userdao.GetEmployeeByFullname(fullname);
        }

        /// <summary>
        /// Get employee by userid
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Employee</returns>
        public Employee ViewEmployeeDetail(int id)
        {
            return empservice.ViewEmployeeDetail(id);
        }

        /// <summary>
        /// Add a employee
        /// </summary>
        /// <param name="userobject">Employee</param>
        /// <returns>Boolean</returns>
        public Boolean AddEmployee(Employee userobject)
        {
            return userdao.AddUser(userobject);
        }

        /// <summary>
        /// Get all product
        /// </summary>
        /// <returns>Database.ProductCategoryDataTable</returns>
        public Database.ProductCategoryDataTable GetAllProduct()
        {
            return productdao.GetAllProduct();
        }

        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id">String</param>
        /// <returns>Product</returns>
        public Product GetProductById(String id)
        {
            return productdao.GetProductByProductId(id);
        }

        /// <summary>
        /// Add product
        /// </summary>
        /// <param name="productobject">Product</param>
        /// <returns>Boolean</returns>
        public Boolean AddProduct(Product productobject)
        {
            return productdao.AddProduct(productobject);
        }

        /// <summary>
        /// Edit product
        /// </summary>
        /// <param name="productobject">Product</param>
        /// <returns>Boolean</returns>
        public Boolean EditProduct(Product productobject)
        {
            return productdao.EditProduct(productobject);
        }

        /// <summary>
        /// Delete product
        /// </summary>
        /// <param name="productid">String</param>
        /// <returns>Boolean</returns>
        public Boolean DeleteProduct(String productid)
        {
            return productdao.DeleteProduct(productid);
        }

        /// <summary>
        /// Get product by productname
        /// </summary>
        /// <param name="productname">String</param>
        /// <returns>ProductCategoryDataTable</returns>
        public Database.ProductCategoryDataTable GetProductByProductName(String productname)
        {
            return productdao.GetProductByProductName(productname);
        }

        /// <summary>
        /// Get product by category
        /// </summary>
        /// <param name="category">String</param>
        /// <returns>Database.ProductCategoryDataTable</returns>
        public Database.ProductCategoryDataTable GetProductByCategory(String category)
        {
            return productdao.GetProductByCategory(category);
        }

        /// <summary>
        /// Get all order
        /// </summary>
        /// <returns>List</returns>
        public List<Order> GetAllOrder()
        {
            return empservice.GetAllOrder();
        }

        /// <summary>
        /// View order detail by orderid
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>Order</returns>
        public Order ViewOrderDetail(int orderid)
        {
            return empservice.ViewOrderDetail(orderid);
        }

        /// <summary>
        /// View admin detail
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Admin</returns>
        public Admin ViewAdminDetail(int id)
        {   
            Admin ad = new Admin();
            User user = userdao.GetUserByUserId(id);
            if (user.UserRole.RoleId == Constant.ROLEID_ADMIN)
                User.Mapping(ad,user);
            return ad;
        
        }
    }
}
