using Repository1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository1.Repository
{
    public class RequestStorage
    {
        private readonly Dictionary<int, Request> _Requests = new();

        public Request Create(Request request)
        {

            _Requests.Add(request.RequestId, request);
            return request;

        }

        public Request Read(int CustomerId)
        {
            return _Requests[CustomerId];
        }

        public Request Update(int RequestId, Request newRequest)
        {
            _Requests[RequestId] = newRequest;
            return _Requests[RequestId];
        }

        public bool Delete(int RequestId)
        {
            return _Requests.Remove(RequestId);
        }
    }
}