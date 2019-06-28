using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Shared.DTO;

namespace BAL.Validators
{
    public class TaskValidator : AbstractValidator<TaskDTO>
    {
        public TaskValidator()
        {
            RuleFor(task => task.TimeSpent).NotNull().GreaterThan(-1);
        }
    }
}
