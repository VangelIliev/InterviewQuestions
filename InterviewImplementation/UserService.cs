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
    public class UserService : ServiceBase, IUserService
    {
        private readonly InterviewQuestionsDbContext _context;
        public UserService(IMapper mapper, InterviewQuestionsDbContext context) : base(mapper)
        {
            this._context = context;
        }
        public Task<Guid> CreateAsync(ApplicationUserModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ApplicationUserModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApplicationUserModel>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserModel> ReadAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ApplicationUserModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
