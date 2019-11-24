﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace NumbersApi
{
    public static class ApiHelper
    {
        public static HttpClient apiClient { get; set; }
        
        public static void InitializeClient() 
        {
            apiClient = new HttpClient();
           

            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}
