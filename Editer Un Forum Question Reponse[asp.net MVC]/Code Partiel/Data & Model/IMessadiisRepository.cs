using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MESSADIIS.Data
{
    public interface IMessadiisRepository
    {
        IQueryable<Question> GetQuestions();
        IQueryable<Reponse> GetReponsesByQuestion(int QuestionId);
    }
}