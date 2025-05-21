
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeesApp.Web.Services;

public class MyServiceAttribute(ILogger<MyServiceAttribute> logger) : ActionFilterAttribute
{

    public override void OnActionExecuting(ActionExecutingContext context) {
        logger.LogInformation("Logging from onactionexecuting: ");

    }

    public override void OnActionExecuted(ActionExecutedContext context) {

        logger.LogWarning("Action has now been executed from my service"); // Logga varning


    }
}
