using Api.Application.Bases;

namespace Api.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpairedException : BaseException
    {
        public RefreshTokenShouldNotBeExpairedException() : base("Oturum süresi sona ermiştir lütfen tekrar giriş yapın!") { }
    }


}
