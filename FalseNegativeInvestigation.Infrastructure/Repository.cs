using Microsoft.EntityFrameworkCore;

namespace FalseNegativeInvestigation.Infrastructure
{
    internal class Repository : IRepository
    {
        protected readonly DbContext DbContext;

        public Repository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void InjectSql(string injection)
        {
            DbContext.Database.ExecuteSqlRaw($"SELECT * FROM public.\"table\" WHERE column_name = '{injection}'");
        }
    }
}
