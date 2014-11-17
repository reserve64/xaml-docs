using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radmap-features-view-modes_0
BingMapProvider bingMap = new BingMapProvider( MapMode.Aerial, true, "key" );
//or
bingMap.Mode = MapMode.Aerial;
bingMap.IsLabelVisible = true;
#endregion
}
