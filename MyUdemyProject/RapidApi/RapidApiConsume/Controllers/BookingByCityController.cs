﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiConsume.Controllers
{
    public class BookingByCityController : Controller
    {
        public async Task<IActionResult> Index(string cityID)
        {
			if (!string.IsNullOrEmpty(cityID))
			{
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-09-27&filter_by_currency=AED&dest_id={cityID}&locale=en-gb&checkout_date=2023-09-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
					Headers =
	{
		{ "X-RapidAPI-Key", "f302b17052mshd4a58640d7e02f8p198534jsn4b646f381d0d" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
					return View(values.results.ToList());

				} 
			}
            else
            {
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-09-27&filter_by_currency=AED&dest_id=-1456928&locale=en-gb&checkout_date=2023-09-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
					Headers =
	{
		{ "X-RapidAPI-Key", "f302b17052mshd4a58640d7e02f8p198534jsn4b646f381d0d" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
					return View(values.results.ToList());

				}
			}
        }
    }
}
