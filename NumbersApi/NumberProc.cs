using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NumbersApi
{
    public class NumberProc
    {
        public static async Task<NumberModel> LoadFact()
        {
            string url = "";

            url = "http://numbersapi.com/random/trivia?json";

            using (HttpResponseMessage response = await ApiHelper.apiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    NumberModel fact = await response.Content.ReadAsAsync<NumberModel>();

                    return fact;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }
    }
}
 