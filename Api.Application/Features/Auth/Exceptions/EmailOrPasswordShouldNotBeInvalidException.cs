using Api.Application.Bases;

namespace Api.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidException : BaseException
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Böyle bir email adresi bulunmamaktadır!")
        {

        }

    }
}
