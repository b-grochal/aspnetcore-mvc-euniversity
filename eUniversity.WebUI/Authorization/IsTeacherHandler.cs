using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Authorization
{
    public class IsTeacherHandler : AuthorizationHandler<IsTeacherRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsTeacherRequirement requirement)
        {
            if (!context.User.IsInRole("Teacher"))
            {
                context.Fail();
            }
            else
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
