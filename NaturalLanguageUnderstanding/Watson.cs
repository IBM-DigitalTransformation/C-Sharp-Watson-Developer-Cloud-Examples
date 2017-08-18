/*
 * Copyright 2017 IBM Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Watson
{
    public class NLU
    {
        private const string endpoint = "https://gateway.watsonplatform.net/natural-language-understanding/api/v1/analyze?version=2017-02-27";
        public static JObject analyzeText(string username, string password, string corpus)
        {
            HttpClientHandler handler = new HttpClientHandler();

            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password)));

            JObject jsonRequestObject = new JObject();
            jsonRequestObject["text"] = corpus;
            jsonRequestObject["features"] = new JObject();
            jsonRequestObject["features"]["categories"] = new JObject();
            jsonRequestObject["features"]["concepts"] = new JObject();
            jsonRequestObject["features"]["concepts"]["limit"] = 50;
            jsonRequestObject["features"]["emotion"] = new JObject();
            jsonRequestObject["features"]["entities"] = new JObject();
            jsonRequestObject["features"]["entities"]["emotion"] = true;
            jsonRequestObject["features"]["entities"]["sentiment"] = true;
            jsonRequestObject["features"]["entities"]["limit"] = 250;
            jsonRequestObject["features"]["keywords"] = new JObject();
            jsonRequestObject["features"]["keywords"]["emotion"] = true;
            jsonRequestObject["features"]["keywords"]["sentiment"] = true;
            jsonRequestObject["features"]["keywords"]["limit"] = 250;
            jsonRequestObject["features"]["sentiment"] = new JObject();


            // List data response.
            Console.WriteLine("Request Content: " + jsonRequestObject.ToString());
            HttpContent requestContent = new StringContent(jsonRequestObject.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = client.PostAsync(endpoint, requestContent).Result;  // Blocking call!
            if (responseMessage.IsSuccessStatusCode)
            {
                string responseContent = responseMessage.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Response Content: " + responseContent);
                return JObject.Parse(responseContent);
            }
            else
            {
                string responseContent = responseMessage.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Response Content: " + responseContent);

                JObject responseObject;
                try
                {
                    responseObject = JObject.Parse(responseContent);
                }
                catch (JsonReaderException ex)
                {
                    responseObject = new JObject(
                        new JProperty("exception", ex.Message)
                    );
                }
                return new JObject(
                    new JProperty("httpstatus", String.Format("{0} ({1})", (int)responseMessage.StatusCode, responseMessage.ReasonPhrase)),
                    new JProperty("error", responseObject)
                );
            }
        }

    }

}
