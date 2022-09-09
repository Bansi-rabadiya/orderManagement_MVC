using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OrderManagement_mvc_DataLayer
{
    public class Order: DataObject
    {
        public Order() : base()
        {

        }
        public Order(SqlTransaction transaction) : base(transaction)
        {

        }
        public Guid OrderId { get; set; }
        public string OrderName { get; set; }
        
        public DateTime OrderDate { get; set; }

        public string OrderStatus { get; set; }

        public Order GetOrder(Guid orderid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            
           var cmd = Transaction != null
               ? new SqlCommand("GetOrder", connection) { CommandType = CommandType.StoredProcedure }
               : new SqlCommand("GetOrder", connection, Transaction) { CommandType = CommandType.StoredProcedure };


            cmd.Parameters.AddWithValue("@orderid", orderid);
            connection.Open();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try 
            {
                sa.Fill(ds);

                
            }
            catch(Exception ex) 
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            //transform the dataset to entites

            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                return new Order()
                {
                    OrderId = orderid,
                    OrderDate = (DateTime)dataRow["OrderDate"],
                    OrderName = dataRow["OrderName"].ToString(),
                    OrderStatus = dataRow[""].ToString()
                };
            }

            return new Order();
        }
        public Order UpadateOrder(Order order)
        {
            return new Order();
        }
        public void DeleteOrder(Guid Orderid)
        {

        }
        public Order CreateOrder(Order order)
        {
            return new Order();
        }

        public List<Order> GetOrders()
        {
            return new List<Order>();
        }
    }
}