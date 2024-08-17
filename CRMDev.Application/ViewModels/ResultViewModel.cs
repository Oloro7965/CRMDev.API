using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.ViewModels
{
    public class ResultViewModel
    {
        public ResultViewModel(bool isSuccess = true, string message = "")
        {
            IsSuccess = isSuccess;

            Message = message;

        }

        public bool IsSuccess { get; private set; }

        public string Message { get; private set; }

        public static ResultViewModel Success()
            => new();

        public static ResultViewModel Error(string message)
            => new(false, message);
    }
    public class ResultViewModel<T> : ResultViewModel
    {
        public ResultViewModel(T? data, bool IsSuccess = true, string message = "") : base(IsSuccess, message)
        {
            Data = data;

        }

        public T? Data { get; private set; }

        public static ResultViewModel<T> Success(T? data) => new(data);

        public static ResultViewModel<T> Error(string message) => new(default, false, message);


    }
}
