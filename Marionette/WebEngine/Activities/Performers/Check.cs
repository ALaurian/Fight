﻿using System.Reflection;
using Microsoft.Playwright;
using Serilog;

namespace Marionette.WebBrowser;

public partial class MarionetteWebBrowser
{
    public IElementHandle Check(string selector, bool lockToLastPage = false)
    {
        var element = FindElement(selector, lockToLastPage);

        if (!element.IsCheckedAsync().Result)
        {
            element.CheckAsync().Wait();
            _logger.LogMessage($"[{MethodBase.GetCurrentMethod().Name}][{selector}] Checked checkbox.");
        }
        else
        {
            _logger.LogMessage($"[{MethodBase.GetCurrentMethod().Name}][{selector}] Checkbox is already checked.");
        }

        return element;
    }
}