using FalseNegativeInvestigation.Infrastructure;

namespace FalseNegativeInvestigation.Application
{
    public class Processor
    {
        private readonly IRepository _repository;

        public Processor(IRepository repository)
        {
            _repository = repository;
        }

        public void Process(string injection)
        {
            _repository.InjectSql(injection);
        }
    }
}
