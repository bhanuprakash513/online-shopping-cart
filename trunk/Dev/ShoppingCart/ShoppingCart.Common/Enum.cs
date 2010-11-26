using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Common
{
    public enum LoginResult 
    {
        Succeed,
        Failed
    }


    public enum Result
    {
        Succeed,
        Failed
    }


    public enum OrderResult
    {
        Succeed,
        Failed,
        OrderCheck,
        OrderUnCheck,
        EndTime
    }

    public enum OrderItemResult
    {
        Succeed,
        Failed,
        OrderCheck,
        OrderUnCheck,
        EndTime,
        NotEmptyProduct
    }

    public enum DateCompareResult
    {
        Great,
        Small,
        Equal
    }
    
}
