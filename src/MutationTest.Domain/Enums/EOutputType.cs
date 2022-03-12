namespace MutationTest.Domain.Enums
{
    public enum EOutputType
    {
        Success = 1,
        InvalidInput,
        BusinessValidation,
        Failure,
        NotFound,
        IntegrationError
    }
}
