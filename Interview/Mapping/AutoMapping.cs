using AutoMapper;
using DbEntities.Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<QuestionAnswer, QuestionAnswerServiceModel>();
            CreateMap<QuestionAnswerServiceModel, QuestionAnswer>();
        }
        //add mapping
        
    }
}
