/**
 * Copyright (C) scenüs, 2025.
 * All rights reserved.
 * Ehsan Haghpanah; haghpanah@scenus.com
 */

using System;
using System.Configuration;
using System.Reflection;

namespace GoldBar
{
	/// <summary>
	/// 
	/// </summary>
	static public class Configuration
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
		private static readonly System.Configuration.Configuration manager;

		static Configuration()
		{
			var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath;
			manager = ConfigurationManager.OpenExeConfiguration(path);
		}

		static public class Urls
		{
			public static string USDIRRRate
			{
				get
				{
					const string title = "url:usd-irr-rate";
					var value = manager.AppSettings.Settings[title].Value;
					if (string.IsNullOrEmpty(value))
						throw new Exception($"ConfigurationIsMissing:{title}");

					return value;
				}
			}

			public static string GoldUSDTicker
			{
				get
				{
					const string title = "url:gold-usd-ticker";
					var value = manager.AppSettings.Settings[title].Value;
					if (string.IsNullOrEmpty(value))
						throw new Exception($"ConfigurationIsMissing:{title}");

					return value;
				}
			}

			public static string GoldIRRGram24
			{
				get
				{
					const string title = "url:gold-irr-gram24";
					var value = manager.AppSettings.Settings[title].Value;
					if (string.IsNullOrEmpty(value))
						throw new Exception($"ConfigurationIsMissing:{title}");

					return value;
				}
			}

			public static string GoldIRRGram18
			{
				get
				{
					const string title = "url:gold-irr-gram18";
					var value = manager.AppSettings.Settings[title].Value;
					if (string.IsNullOrEmpty(value))
						throw new Exception($"ConfigurationIsMissing:{title}");

					return value;
				}
			}
		}
	}
}