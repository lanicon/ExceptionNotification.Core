﻿using ExceptionNotification.Core.Email;
using ExceptionNotification.Core.Hipchat;
using ExceptionNotification.Core.Slack;

namespace ExceptionNotification.Core
{
    public interface IExceptionNotifierConfiguration
    {
        EmailConfiguration Email { get; set; }

        HipchatConfiguration Hipchat { get; set; }

        SlackConfiguration Slack { get; set; }
    }
}
