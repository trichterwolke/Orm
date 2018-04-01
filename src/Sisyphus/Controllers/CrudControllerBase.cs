namespace Sisyphus.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Sisyphus.Dal;
    using System.Collections.Generic;

    public class CrudController<TEntity> : Controller
    {
        private readonly ICrudDal<TEntity> crudDal;

        public CrudController(ICrudDal<TEntity> crudDal)
        {
            this.crudDal = crudDal;
        }

        [HttpGet]
        public IEnumerable<TEntity> FindAll()
        {
            return this.crudDal.FindAll();
        }

        [HttpGet("{id}")]
        public TEntity FindByID(int id)
        {
            return this.crudDal.FindByID(id);
        }
    }
}
