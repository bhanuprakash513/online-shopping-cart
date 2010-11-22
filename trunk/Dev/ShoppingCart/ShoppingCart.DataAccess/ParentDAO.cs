using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class ParentDAO
    {
        protected SqlConnection conn;
        protected SqlCommand cmd;
        protected SqlDataAdapter adapter;
        protected String query;
        protected SqlParameter[] paramCollection;
        /// <summary>
        /// Lay chuoi ket noi voi database
        /// </summary>
        private String connectionString
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("ShoppingCart.ConnectionString").ToString();
            }
        }

        /// <summary>
        /// Khoi tao doi tuong
        /// </summary>
        public ParentDAO()
        {
            conn = new SqlConnection(this.connectionString);
            cmd = new SqlCommand();
            adapter = new SqlDataAdapter();
        }


        /// <summary>
        /// Khoi tao ket noi
        /// </summary>
        /// <returns>Boolean</returns>
        protected Boolean InitConnect()
        {

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            if (conn.State == ConnectionState.Open)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Dong ket noi
        /// </summary>
        protected void CloseConnect()
        {
            
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            
        }


        /// <summary>
        /// Fill du lieu vao table
        /// </summary>
        /// <param name="command">String</param>
        /// <param name="param">SqlParameter[]</param>
        /// <param name="dt">DataTable</param>
        /// <returns>int</returns>
        protected int Fill(String command,SqlParameter[] param,DataTable dt)
        {
            try
            {
                
                if (InitConnect())
                {
                    cmd = new SqlCommand(command,conn);
                    this.MappingParameters(cmd.Parameters, param);

                    adapter.SelectCommand = cmd;
                    adapter.SelectCommand.CommandType = CommandType.Text;
                    adapter.Fill(dt);
                    

                 }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                CloseConnect();
            }
            return 0;
        }



        /// <summary>
        /// Fill du lieu vao table
        /// </summary>
        /// <param name="command">String</param>
        /// <param name="dt">DataTable</param>
        /// <returns>int</returns>
        protected int Fill(String command, DataTable dt)
        {
            try
            {

                if (InitConnect())
                {
                    cmd = new SqlCommand(command, conn);
                    this.MappingParameters(cmd.Parameters, null);

                    adapter.SelectCommand = cmd;
                    adapter.SelectCommand.CommandType = CommandType.Text;
                    adapter.Fill(dt);


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                CloseConnect();
            }
            return 0;
        }

      

        /// <summary>
        /// Thuc thi cau truy van
        /// </summary>
        /// <param name="command">String</param>
        /// <param name="param">SqlParameter[]</param>
        /// <returns>Boolean</returns>
        protected Boolean ExecuteNonQuery(String command,SqlParameter[] param)
        {

            try
            {
                if (InitConnect())
                {
                    cmd = new SqlCommand(command,conn);
                    this.MappingParameters(cmd.Parameters, param);
                    cmd.CommandType = CommandType.Text;
                    if (cmd.ExecuteNonQuery() == 0)
                        return false;
                    else
                        return true;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                CloseConnect();
            }
            return false;
        }


        /// <summary>
        /// Thuc thi cau truy van
        /// </summary>
        /// <param name="command">String</param>
        /// <returns>Boolean</returns>
        protected Boolean ExecuteNonQuery(String command)
        {

            try
            {
                if (InitConnect())
                {
                    cmd = new SqlCommand(command, conn);
                    this.MappingParameters(cmd.Parameters,null);
                    cmd.CommandType = CommandType.Text;
                    if (cmd.ExecuteNonQuery() == 0)
                        return false;
                    else
                        return true;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                CloseConnect();
            }
            return false;
        }


        protected void MappingParameters(SqlParameterCollection paramCollection, SqlParameter[] paramArray)
        {
            if (paramArray != null)
            {
                for (int i = 0; i < paramArray.Length; i++)
                {
                    paramCollection.Add(paramArray[i]);
                }
            }

        }



        /// <summary>
        /// Fill du lieu vao table
        /// </summary>
        /// <param name="command">String</param>
        /// <param name="param">SqlParameter[]</param>
        /// <param name="dt">DataTable</param>
        /// <returns>int</returns>
        protected int FillStore(String command, SqlParameter[] param, DataTable dt)
        {
            try
            {

                if (InitConnect())
                {
                    cmd = new SqlCommand(command, conn);
                    this.MappingParameters(cmd.Parameters, param);

                    adapter.SelectCommand = cmd;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dt);


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                CloseConnect();
            }
            return 0;
        }



        /// <summary>
        /// Fill du lieu vao table
        /// </summary>
        /// <param name="command">String</param>
        /// <param name="dt">DataTable</param>
        /// <returns>int</returns>
        protected int FillStore(String command, DataTable dt)
        {
            try
            {

                if (InitConnect())
                {
                    cmd = new SqlCommand(command, conn);
                    this.MappingParameters(cmd.Parameters, null);

                    adapter.SelectCommand = cmd;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dt);


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                CloseConnect();
            }
            return 0;
        }



        /// <summary>
        /// Thuc thi cau truy van
        /// </summary>
        /// <param name="command">String</param>
        /// <param name="param">SqlParameter[]</param>
        /// <returns>Boolean</returns>
        protected Boolean ExecuteStore(String command, SqlParameter[] param)
        {

            try
            {
                if (InitConnect())
                {
                    cmd = new SqlCommand(command, conn);
                    this.MappingParameters(cmd.Parameters, param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.ExecuteNonQuery() == 0)
                        return false;
                    else 
                        return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                CloseConnect();
            }
            return false;
        }


        /// <summary>
        /// Thuc thi cau truy van
        /// </summary>
        /// <param name="command">String</param>
        /// <returns>Boolean</returns>
        protected Boolean ExecuteStore(String command)
        {

            try
            {
                if (InitConnect())
                {
                    cmd = new SqlCommand(command, conn);
                    this.MappingParameters(cmd.Parameters, null);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.ExecuteNonQuery() == 0)
                        return false;
                    else
                        return true;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                CloseConnect();
            }
            return false;
        }

    }
}
