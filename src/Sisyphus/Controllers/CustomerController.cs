namespace Sisyphus.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Sisyphus.Dal;
    using Sisyphus.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class CustomerController : CrudController<Customer>
    {
        public CustomerController(ICustomerDal customerDal)
            : base(customerDal)
        {

        }
    }
}
