using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Umbraco.Databases
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class EmployeeComposer : ComponentComposer<EmployeeComponents>
    {
    }
}