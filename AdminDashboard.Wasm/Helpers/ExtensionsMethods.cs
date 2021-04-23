﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Specialized;
using System.Web;

namespace AdminDashboard.Wasm.Helpers
{
    public static class ExtensionsMethods
    {
        public static NameValueCollection QueryString(this NavigationManager navigationManager)
        {
            return HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);
        }

        public static string QueryString(this NavigationManager navigationManager, string key)
        {
            return navigationManager.QueryString()[key];
        }
    }
}
