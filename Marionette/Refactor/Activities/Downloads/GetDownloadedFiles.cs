﻿using Microsoft.Playwright;

namespace Marionette.WebBrowser;

public partial class MarionetteWebBrowser
{
    public List<IDownload> GetDownloadedFiles(string elementToVanish, int retries, bool lockToLastPage)
    {
        WaitElementVanish(elementToVanish, retries, lockToLastPage);
        while (!_fileDownloadSession.Any())
        {
        }

        while (_fileDownloadSession.Any())
        {
        }

        var downloadedFilesList = _downloadedFiles;
        _downloadedFiles = new List<IDownload>();
        return downloadedFilesList;
    }

    public List<IDownload> GetDownloadedFiles()
    {
        while (!_fileDownloadSession.Any())
        {
        }

        while (_fileDownloadSession.Any())
        {
        }

        var downloadedFilesList = _downloadedFiles;
        _downloadedFiles = new List<IDownload>();
        return downloadedFilesList;
    }
}