using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message??GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return StatusCode switch
            {
                400=>"A bad request you have made",
                401=>"Authorized you are not",
                404=>"Resource found, was not",
                500=>"Errors are the path to the darkside. Errors lead to anger. Anger leads to hate. Hate leads to career change",
                _=> null
            };
        }

        public int StatusCode{get;set;}
        public string Message{get;set;}
    }
}