using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Application.Models
{
    public class Response<T>
    {
        public bool Succeeded { get; set; }
        public string? Message { get; set; }
        public List<Error> Errors { get; set; } = null!;
        public T Data { get; set; }

        public Response()
        {
        }

        public Response(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }

        public TResult Match<TResult>(Func<T, TResult> onValue, Func<List<Error>, TResult> onError)
        {
            if (!Succeeded)
            {
                return onError(Errors);
            }

            return onValue(Data);
        }
    }

    public record Error(string Msg)
    {
        public ErrorType Type { get; set; }
        public string Message { get; set; }
        public Error(ErrorType error, string Msg) : this(Msg)
        {
        }
    }
    public enum ErrorType
    {
        Conflict,
        Validation,
        NotFound,
        Failure,
        Unexpected,
        Bussiness,
    }
}
