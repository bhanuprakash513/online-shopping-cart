using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using ShoppingCart.DataAccess;
using ShoppingCart.Common;

namespace ShoppingCart.Business
{
    public class EmployeeService
    {
        OrderDAO orderdao;
        UserDAO userdao;


        /// <summary>
        /// Init
        /// </summary>
        public EmployeeService()
        {
            orderdao = new OrderDAO();
            userdao = new UserDAO();
        }

        /// <summary>
        /// Search Order by date and delivery
        /// </summary>
        /// <param name="deliveryid">char</param>
        /// <param name="startdate">DateTime</param>
        /// <param name="enddate">DateTime</param>
        /// <returns>List</returns>
        public List<Order> SearchByDateAnDeliveryOfOrder(char deliveryid, DateTime startdate, DateTime enddate)
        {
            return orderdao.GetOrderByDateAndDeliveryId(deliveryid, startdate, enddate);
        }

        /// <summary>
        /// Update pay status of order
        /// </summary>
        /// <param name="statuspaidid">int</param>
        /// <param name="orderid">int</param>
        /// <returns>Boolean</returns>
        public Boolean UpdatePayStatusOfOrder(int statuspaidid, int orderid)
        {
            return orderdao.UpdateStatusPaidIdByOrderId(statuspaidid, orderid);
        }

        /// <summary>
        /// Update delivery status of order
        /// </summary>
        /// <param name="statusdeliveryid">int</param>
        /// <param name="orderid">int</param>
        /// <param name="shippingdate">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean UpdateDeliveryStatusOfOrder(int statusdeliveryid, int orderid, DateTime shippingdate)
        {
            return orderdao.UpdateStatusDeliveryIdByOrderId(statusdeliveryid, orderid, shippingdate);
        }

        /// <summary>
        /// Update userid ship of order
        /// </summary>
        /// <param name="useridship">int</param>
        /// <param name="orderid">int</param>
        /// <returns>Boolean</returns>
        public Boolean UpdateUserShipOfOrder(int useridship, int orderid)
        {
            return orderdao.UpdateUserIdShipByOrderId(useridship, orderid);        
        }

        /// <summary>
        /// View order detail by id
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>Order</returns>
        public Order ViewOrderDetail(int orderid)
        {
            return orderdao.GetOrderByOrderId(orderid);
        }

        /// <summary>
        /// change password
        /// </summary>
        /// <param name="pass">String</param>
        /// <param name="userid">int</param>
        /// <returns>Boolean</returns>
        public Boolean ChangePassword(String pass, int userid)
        {
            return userdao.ChangePassword(pass, userid);
        }

        /// <summary>
        /// Get all order
        /// </summary>
        /// <returns>List</returns>
        public List<Order> GetAllOrder()
        {
            return orderdao.GetAllOrder();
        }

        /// <summary>
        /// Get user by userid
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>User</returns>
        public Employee ViewEmployeeDetail(int id)
        {
            Employee emp = new Employee();
            User user = userdao.GetUserByUserId(id);
            if (user.UserRole.RoleId == Constant.ROLEID_EMPLOYEE)
                User.Mapping(emp, user);
            return emp;
        }

    }
}
