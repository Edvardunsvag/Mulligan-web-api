using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MulliganApi.Authentication;

public class ApiKeyAuthFilter : IAuthorizationFilter
{
    private readonly IConfiguration _configuration;
    private readonly IHostEnvironment _environment;

    public ApiKeyAuthFilter(IConfiguration configuration, IHostEnvironment environment)
    {
        _configuration = configuration;
        _environment = environment;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        if (_environment.IsDevelopment()) return;
        if (!context.HttpContext.Request.Headers.TryGetValue(AuthConstants.ApiKeyHeaderName,  out var extractedApiKey))
        {
            context.Result = new UnauthorizedObjectResult("Api Key Missing");
            return;
        }

        var apiKey = _configuration.GetValue<string>(AuthConstants.ApiKeySectionName);
        if (!apiKey.Equals(extractedApiKey))
        {
            context.Result = new UnauthorizedObjectResult("Invalid api key");
            return;
        }
    }
}