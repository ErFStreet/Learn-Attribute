namespace App.Instructure.Attributes;

// This Attribute is for Class ,and Method.

// You can set in here with => AttributeUsage

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]

// ActionFilterAttribute <= This Attribute is for information of Methods , and Class
public class InformationAttribute : ActionFilterAttribute 
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        // Action info

        var actionDescriptor = context.ActionDescriptor;

        await Task.CompletedTask;
    }
}
