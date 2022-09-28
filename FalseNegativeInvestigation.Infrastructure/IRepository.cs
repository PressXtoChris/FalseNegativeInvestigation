namespace FalseNegativeInvestigation.Infrastructure
{
    public interface IRepository
    {
        void InjectSql(string injection);
    }
}
