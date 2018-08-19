using GraphQL.Types;
using System;

namespace GraphQL.Orders.Schema
{
    public class OrdersSchema : GraphQL.Types.Schema
    {
        public OrdersSchema(Func<Type, GraphType> resolveType)
           : base(resolveType)
        {
            Query = (OrdersQuery)resolveType(typeof(OrdersQuery));
        }
    }
}
