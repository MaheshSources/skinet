using System;

namespace API.Errors
{
  public class ApiResponse
  {
    public ApiResponse(int statusCode, string message = null)
    {
      StatusCode = statusCode;
      Message = message ?? GetDefaultMessageForStatusCode(statusCode);
    }

    public int StatusCode { get; set; }

    public string Message { get; set; }


    private string GetDefaultMessageForStatusCode(int statusCode)
    {

      return statusCode switch
      {
        400 => "A Bad request, you havemade",
        401 => "Authorised, you are not found",
        404 => "Resouce Found, it was not",
        500 => "Errors are the path to the dark side. Errors lead to anger. Anger leads to hate.",
        _ => null
      };

    }



  }





}