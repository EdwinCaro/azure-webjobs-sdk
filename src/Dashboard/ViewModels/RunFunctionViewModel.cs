﻿using System;
using System.Collections.Generic;

namespace Dashboard.ViewModels
{
    public class RunFunctionViewModel
    {
        public string FunctionId { get; set; }
        public Guid HostId { get; set; }
        public IEnumerable<FunctionParameterViewModel> Parameters { get; set; }
        public Guid? ParentId { get; set; }

        public string FunctionName { get; set; }
        public bool HostIsNotRunning { get; set; }
        public string SubmitText { get; set; }
    }
}
