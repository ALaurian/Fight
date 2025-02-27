﻿using FlaUI.Core.AutomationElements;
using FlaUI.UIA3.Patterns;
using Polly;

namespace Marionette.WinEngine;

public partial class MarionetteWinBrowser
{
    public void SendText(bool simulateType, string text)
    {
        var retryPolicy = Policy
            .Handle<Exception>()
            .WaitAndRetry(
                retryCount,
                retryAttempt => RetryTimeSpan,
                (ex, timespan, retryCount, context) =>
                {
                    Console.WriteLine($"Error sending text: {ex.Message}");
                    Console.WriteLine($"Retrying text sending. {retryCount} retries left.");
                });

        retryPolicy.Execute(() =>
        {
            try
            {
                if (simulateType)
                {
                    //ActiveElement.AsTextBox().Enter(text);
                    ((ValuePattern)ActiveElement.Patterns.Value.Pattern).SetValue(text);
                }
                else
                {
                    ActiveElement.AsTextBox().Text = text;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        });
    }

}