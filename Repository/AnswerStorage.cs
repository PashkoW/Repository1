using Repository1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository1.Repository
{
    public class AnswerStorage
    {
        private readonly Dictionary<int, Answer> _Answers = new();

        public Answer Create(Answer answer)
        {

            _Answers.Add(answer.Id, answer);
            return answer;

        }

        public Answer Read(int Id)
        {
            return _Answers[Id];
        }

        public Answer Update(int Id, Answer newAnswer)
        {
            _Answers[Id] = newAnswer;
            return _Answers[Id];
        }

        public bool Delete(int Id)
        {
            return _Answers.Remove(Id);
        }
    }
}