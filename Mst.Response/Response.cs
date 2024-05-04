using System.Net;
using System.Text.Json.Serialization;

namespace Mst.Response;

public sealed class Response<T>
{
    public T? Data { get; private set; }
    public int StatusCode { get; set; } = (int)HttpStatusCode.OK;
    public string? Message { get; set; }
    
    [JsonIgnore] 
    public bool IsSuccessful { get; private set; }

    public List<string> Errors { get; private set; } = new List<string>();

    public static Response<T> Success(T data, int statusCode)
    {
        return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessful = true};
    }
    
    public static Response<T> Success(int statusCode)
    {
        return new Response<T> { Data = default, StatusCode = statusCode, IsSuccessful = true };
    }

    public static Response<T> Success(string message, int statusCode)
    {
        return new Response<T> { Data = default, Message = message, StatusCode = statusCode, IsSuccessful = true };
    }
    
    public static Response<T> Fail(string errorMessage, int statusCode)
    {
        return new Response<T> { Message  = errorMessage ,StatusCode = statusCode, IsSuccessful = false };
    }
    
    public static Response<T> Fail(List<string> errors, int statusCode)
    {
        return new Response<T> { Errors = errors, StatusCode = statusCode, IsSuccessful = false};
    }

}