
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeesApp.Web.Services;

public class MyServiceAttribute(ILogger<MyServiceAttribute> logger, string message) : ActionFilterAttribute
{

    public override void OnActionExecuting(ActionExecutingContext context) {
        logger.LogInformation("Logging from onactionexecuting: {message}", message);
        base.OnActionExecuting(context);
    }

    public override void OnActionExecuted(ActionExecutedContext context) {

        logger.LogWarning("Action has now been executed from my service"); // Logga varning

        base.OnActionExecuted(context);
    }
}
