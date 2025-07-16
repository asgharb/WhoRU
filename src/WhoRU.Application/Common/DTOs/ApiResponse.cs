﻿namespace WhoRU.Application.Common.DTOs
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }

        public ApiResponse() { }

        public ApiResponse(T data, string? message = null, bool success = true)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public static ApiResponse<T> Fail(string message)
        {
            return new ApiResponse<T>(default, message, false);
        }

        public static ApiResponse<T> Ok(T data, string? message = null)
        {
            return new ApiResponse<T>(data, message, true);
        }
    }
}
