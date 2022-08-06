using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows;

namespace TankGameLauncher
{
	enum LauncherStatus 
	{
		ready,
		failed,
		downloadingGame,
		downloadingUpdate
	}
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private string rootPath;
		private string versionFile;
		private string gameZip;
		private string gameExe;
		public MainWindow()
		{
			InitializeComponent();

			rootPath = Directory.GetCurrentDirectory();
			versionFile = Path.Combine(rootPath, "Version.txt");
			gameZip = Path.Combine(rootPath, "Build.zip");
			gameExe = Path.Combine(rootPath, "Build", "TankGame.exe");
		}

		private void Window_ContentRendered(object sender, EventArgs e)
		{

		}

		private void PlayButton_Click(object sender, RoutedEventArgs e)
		{

		}
	}
	struct Version 
	{
		internal static Version zero = new Version(0, 0, 0);

		private short major;
		private short minor;
		private short subMinor;

		internal Version(short _major, short _minor, short _subMinor) 
		{
			major = _major;
			minor = _minor;
			subMinor = _subMinor;
		}
		internal Version(string _version) 
		{

		}
	}
}
