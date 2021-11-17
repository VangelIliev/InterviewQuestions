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
    public class AnswerService : ServiceBase,IAnswerService
    {
        private readonly InterviewQuestionsDbContext _context;
        public AnswerService(IMapper mapper, InterviewQuestionsDbContext context) : base(mapper)
        {
            this._context = context;
        }

        public Task<Guid> CreateAsync(QuestionAnswerServiceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(QuestionAnswerServiceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<QuestionAnswerServiceModel>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<QuestionAnswerServiceModel> ReadAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(QuestionAnswerServiceModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
