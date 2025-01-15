using MyRecipeBook.Communication.Responses;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Application.UseCases.User.Register;
public class RegisterUserUseCase
{
    public ResponseRegisteredUserJson Execute(RequestRegisterUserJson request)
    {
        // validar a request
        Validate(request);

        // mapear a request para a entidade

        // criptografar a senha

        // salvar no banco de dados

        return new ResponseRegisteredUserJson
        {
            Name = request.Name,
        };
    }

    private void Validate(RequestRegisterUserJson request)
    {
        var validator = new RegisterUserValidator();

        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(e => e.ErrorMessage);
            throw new Exception();
        }
    }
}
