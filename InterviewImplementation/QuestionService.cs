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
    public class QuestionService : ServiceBase,IQuestionService
    {
        private readonly InterviewQuestionsDbContext _context;
        public QuestionService(IMapper mapper, InterviewQuestionsDbContext context) : base(mapper)
        {
            this._context = context;
        }

        public Task<Guid> CreateAsync(QuestionServiceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(QuestionServiceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<QuestionServiceModel>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<QuestionServiceModel> ReadAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(QuestionServiceModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
