using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Authorization
{
    public class IsStudentHandler : AuthorizationHandler<IsStudentRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsStudentRequirement requirement)
        {
            if (!context.User.IsInRole("Student"))
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
