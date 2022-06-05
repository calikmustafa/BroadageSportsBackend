﻿using BroadageSportsBackend.Core.Pagination;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text;

namespace BroadageSportsBackend.Api.Helpers
{
    
        public static class Extensions
        {
            
            public static void AddApplicationError(this HttpResponse response, string message)
            {
                response.Headers.Add("Application-Error", message);
                response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
                response.Headers.Add("Access-Control-Allow-Origin", "*");

            }

            public static void AddPagination(this HttpResponse response, int pageNumber, int pageSize, int totalItems, int totalPages, string searchText, string orderBy, bool orderbyasc)
            {
                if (!String.IsNullOrEmpty(searchText))
                {
                    searchText = Convert.ToBase64String(Encoding.UTF8.GetBytes(searchText));
                }

                var paginationHeader = new PaginationHeader(pageNumber, pageSize, totalItems, totalPages, searchText, orderBy, orderbyasc);

                var camelCaseFormatter = new JsonSerializerSettings();
                camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

                response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, camelCaseFormatter));
                response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
            }



            public static int CalculateAppointment(this DateTime theDateTime, DateTime endTime)
            {
                int result = Convert.ToInt32(endTime.Subtract(theDateTime).TotalMinutes);

                return result;
            }


            public static int CalculateAppointmentRemainingMin(this DateTime theDateTime)
            {
                double remtime = theDateTime.Subtract(DateTime.Now).TotalMinutes;
                return Convert.ToInt32(remtime);
            }


            public static int CalculateAppointmentRemainingMinToEnd(this DateTime theDateTime)
            {
                double remtime = theDateTime.Subtract(DateTime.Now).TotalMinutes;
                return Convert.ToInt32(remtime);
            }
        }
    }

