﻿using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TPPCore.Client.Common;

namespace TPPCore.Client.Example.Parrot
{
    public class ParrotClient
    {
        private string Url;
        private RestfulClient HttpClient;
        public ParrotClient(string Url, RestfulClient HttpClient)
        {
            this.Url = Url;
            this.HttpClient = HttpClient;
        }
        public async Task<ReadOnlyCollection<string>> GetRecent()
        {
            string unparsed = await CommonClient.GetAsync(new Uri($"{Url}message/recent"), HttpClient);
            ReadOnlyCollection<string> parsed = JsonConvert.DeserializeObject<ReadOnlyCollection<string>>(unparsed);
            return parsed;
        }
        public async Task<string> GetCurrent()
        {
            string unparsed = await CommonClient.GetAsync(new Uri($"{Url}message/current"), HttpClient);
            string parsed = JsonConvert.DeserializeObject<string>(unparsed);
            return parsed;
        }
        public async Task PostMessage(string message)
        {
            string serialized = JsonConvert.SerializeObject(message);
            await CommonClient.PostAsync(new Uri($"{Url}message/new"), serialized, HttpClient);
        }
    }
}
