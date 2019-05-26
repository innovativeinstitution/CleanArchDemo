using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Commands
{
    public abstract class CourseCommand : Command
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}
