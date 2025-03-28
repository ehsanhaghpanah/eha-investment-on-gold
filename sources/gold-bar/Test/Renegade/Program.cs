/**
 * Copyright (C) scenüs, 2025.
 * All rights reserved.
 * Ehsan Haghpanah; haghpanah@scenus.com
 */

using System;
using HtmlAgilityPack;

namespace Renegade
{
	internal class Program
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		static void Main(string[] args)
		{
			var scrapper = new GoldBar.WebScrapper();

			Console.WriteLine($"Gold USD Ticker = {GetGoldUSDTicker()}");
			//Console.WriteLine($"USD IRR Rate = {scrapper.GetUSDIRRRate()}");
			//Console.WriteLine($"Gold IRR Gram 24 = {scrapper.GetGoldIRRGram24()}");
			//Console.WriteLine($"Gold IRR Gram 18 = {scrapper.GetGoldIRRGram18()}");
		}

		static long GetGoldUSDTicker()
		{
			try
			{
				var page = new HtmlWeb();
				var html = page.Load(GoldBar.Configuration.Urls.GoldUSDTicker);
				var node = html.DocumentNode.SelectNodes("//main")[0];
				node = node.SelectNodes("//div[@class='container']")[0];
				node = node.SelectNodes("//div[@class='gold-change']")[0];
				Console.WriteLine(node.ChildNodes.Count);

				//var n = html.DocumentNode.SelectNodes("//div[@class='node__content']")[0];
				//Console.WriteLine(n.InnerHtml);

				return 0;
			}
			catch (Exception p)
			{
				logger.Error(p);
				return -1;
			}
		}
	}
}