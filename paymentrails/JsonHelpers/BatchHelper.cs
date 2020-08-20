﻿using System;
using PaymentRails.Types;
// using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Text.Json;

namespace PaymentRails.JsonHelpers
{
    public class BatchHelper : JsonHelper
    {
        /// <summary>
        /// Method that converts a JSON string to a List of Batch objects
        /// </summary>
        /// <param name="jsonResponse"></param>
        /// <returns>The List of Batches that the JSON object represented</returns>
        public static List<Batch> JsonToBatchList(string jsonResponse)
        {
            if (jsonResponse == null || jsonResponse == "")
            {
                throw new ArgumentException("JSON must be provided");
            }

            BatchListJsonHelper helper = JsonSerializer.Deserialize<BatchListJsonHelper>(jsonResponse);
            List<Batch> batches = new List<Batch>();
            if (helper.Ok)
            {
                foreach (BatchJsonHelper b in helper.Batches)
                {
                    batches.Add(BatchJsonHelperToBatch(b));
                }
            }
            return batches;
        }

        /// <summary>
        /// Method that converts a JSON string into a Batch object
        /// </summary>
        /// <param name="jsonResponse"></param>
        /// <returns>The Batch that the JSON string represented</returns>
        public static Batch JsonToBatch(string jsonResponse)
        {
            if (jsonResponse == null || jsonResponse == "")
            {
                throw new ArgumentException("JSON must be provided");
            }

            BatchResponseJsonHelper helper = JsonSerializer.Deserialize<BatchResponseJsonHelper>(jsonResponse);
            if (helper.Ok)
            {
                return BatchJsonHelperToBatch(helper.Batch);
            }
            return null;
        }
    }
}
