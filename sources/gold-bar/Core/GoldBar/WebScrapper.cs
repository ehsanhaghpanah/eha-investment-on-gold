/**
 * Copyright (C) scenüs, 2025.
 * All rights reserved.
 * Ehsan Haghpanah; haghpanah@scenus.com
 */

using System;
using System.Runtime.InteropServices;
using HtmlAgilityPack;

namespace GoldBar
{
	/// <summary>
	/// WebScrapper (Interface)
	/// </summary>
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[Guid("26950555-3231-4519-AF70-9CC870D1CF98")]
	public interface IWebScrapper
	{
		long GetUSDIRRRate();
		long GetGoldIRRGram24();
		long GetGoldIRRGram18();
	}

	/// <summary>
	/// WebScrapper
	/// </summary>
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("D490B988-B65F-4F10-BA0B-0770CACDBA35")]
	[ProgId("GoldBarDll.WebScrapper")]
	public sealed class WebScrapper : IWebScrapper
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public long GetUSDIRRRate()
		{
			try
			{
				var page = new HtmlWeb();
				var html = page.Load(Configuration.Urls.USDIRRRate);
				var data = html.DocumentNode.SelectNodes("//span[@data-col='info.last_trade.PDrCotVal']")[0].InnerText;
				data = data.Replace(",", "");
				return long.Parse(data);
			}
			catch (Exception p)
			{
				logger.Error(p);
				return -1;
			}
		}

		public long GetGoldIRRGram24()
		{
			try
			{
				var page = new HtmlWeb();
				var html = page.Load(Configuration.Urls.GoldIRRGram24);
				var data = html.DocumentNode.SelectNodes("//span[@data-col='info.last_trade.PDrCotVal']")[0].InnerText;
				data = data.Replace(",", "");
				return long.Parse(data);
			}
			catch (Exception p)
			{
				logger.Error(p);
				return -1;
			}
		}

		public long GetGoldIRRGram18()
		{
			try
			{
				var page = new HtmlWeb();
				var html = page.Load(Configuration.Urls.GoldIRRGram18);
				var data = html.DocumentNode.SelectNodes("//span[@data-col='info.last_trade.PDrCotVal']")[0].InnerText;
				data = data.Replace(",", "");
				return long.Parse(data);
			}
			catch (Exception p)
			{
				logger.Error(p);
				return -1;
			}
		}
	}
}