﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace NationalBank.BackEnd.Extensions
{
    public static class TempDataExtesions
    {
        public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class => tempData[key] = JsonConvert.SerializeObject(value);

        public static T Get<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            tempData.TryGetValue(key, out object o);
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }
    }
}
