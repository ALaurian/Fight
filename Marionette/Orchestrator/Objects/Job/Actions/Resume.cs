﻿using Marionette.Orchestrator.Enums;

namespace Marionette.Orchestrator;

public partial class Job
{
    public void Resume()
    {
        State = JobState.Running;
    }
}