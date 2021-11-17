using AutoMapper;
using DbEntities.DBContext;
using InterviewContracts;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewImplementation
{
    public class TestService : ServiceBase,ITestService
    {
        private readonly InterviewQuestionsDbContext _context;
        public TestService(IMapper mapper, InterviewQuestionsDbContext context) : base(mapper)
        {
            this._context = context;
        }

        public Task<Guid> CreateAsync(TestServiceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TestServiceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TestServiceModel>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TestServiceModel> ReadAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TestServiceModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
