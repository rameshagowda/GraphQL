using GraphQL.Types;
using GraphQL.Orders.Models;

namespace GraphQL.Orders.Schema
{
    public class CustomerType:ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(c => c.Id);
            Field(c => c.Name);
        }
    }
}
