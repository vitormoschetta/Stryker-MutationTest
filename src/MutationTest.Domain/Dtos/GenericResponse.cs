using MutationTest.Domain.Enums;

namespace MutationTest.Domain.Dtos
{
    public class GenericResponse
    {
        public GenericResponse()
        {
            OutputType = EOutputType.Success;
        }

        public GenericResponse(object data)
        {
            OutputType = EOutputType.Success;
            Data = data;
        }

        public GenericResponse(string message, EOutputType outputType)
        {
            Message = message;
            OutputType = outputType;
        }

        public GenericResponse(string message, EOutputType outputType, object data)
        {
            Message = message;
            OutputType = outputType;
            Data = data;
        }

        public GenericResponse(EOutputType outputType)
        {
            OutputType = outputType;
        }

        public GenericResponse(Exception e)
        {
            OutputType = EOutputType.Failure;
            Message = e.Message;
        }

        public EOutputType OutputType { get; set; }
        public bool Success => OutputType == EOutputType.Success;
        public string? Message { get; set; }
        public object? Data { get; set; }
    }
}