using NovaPoshta.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NovaPoshta.Client.Extensions
{
    public static class ResponsePayloadExtentions
    {
        public static List<ErrorModel> ToErrorList<T>(this ResponsePayload<T> response)
        {
            var errors = new List<ErrorModel>();

            if (response == null || !response.Errors.Any())
            {
                return errors;
            }

            for (int i = 0; i < response.Errors.Count; i++)
            {
                errors.Add(new ErrorModel(response.ErrorCodes[i], response.Errors[i]));
            }

            return errors;
        }
    }
}
