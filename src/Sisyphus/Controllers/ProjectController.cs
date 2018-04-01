namespace Sisyphus.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Sisyphus.Dal;
    using Sisyphus.Entities;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    public class ProjectController : CrudController<Project>
    {
        private readonly IProjectDal projectDal;

        public ProjectController(IProjectDal projectDal)
            :base(projectDal)
        {
            this.projectDal = projectDal;
        }

        [HttpGet("[action]")]
        public IEnumerable<Project> FindByCustomer()//(int? customerID)
        {
            return this.projectDal.FindByCustomer(null);
        }
    }
}
