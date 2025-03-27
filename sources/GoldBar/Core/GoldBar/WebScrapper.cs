/**
 * Copyright (C) scenüs, 2025.
 * All rights reserved.
 * Ehsan Haghpanah; haghpanah@scenus.com
 */

using System.Runtime.InteropServices;

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
		double GetCurrentPrice();
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
		public double GetCurrentPrice()
		{
			return 1001;
		}
	}
}