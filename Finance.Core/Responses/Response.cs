﻿using System.Text.Json.Serialization;

namespace Finance.Core.Responses;

public abstract class Response<TData>
{
    private int _statusCode = Configuration.DefaultStatusCode;

    [JsonConstructor]
    public Response() => _statusCode = Configuration.DefaultStatusCode;


    public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null)
    {
        Data = data;
        _statusCode = code;
        Message = message;
    }

    public TData? Data { get; set; }
    public string? Message { get; set; }
    [JsonIgnore]
    public bool IsSuccess => _statusCode is >= 200 and <= 299;
}
