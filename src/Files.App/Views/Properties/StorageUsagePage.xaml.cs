// Copyright (c) 2023 Files Community
// Licensed under the MIT License. See the LICENSE.

using CommunityToolkit.WinUI;
using Files.App.Data.Items;
using Files.App.Extensions;
using Files.App.Filesystem;
using Files.App.Helpers;
using Files.App.Shell;
using Files.App.ViewModels.Properties;
using Files.Shared;
using Files.Shared.Enums;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Input;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Storage;

namespace Files.App.Views.Properties
{
	public sealed partial class StorageUsagePage : BasePropertiesPage
	{
		private readonly Regex letterRegex = new(@"\s*\(\w:\)$");

		public StorageUsagePage()
		{
			InitializeComponent();
		}

		public override void Dispose()
		{
		}

		protected override void Properties_Loaded(object sender, RoutedEventArgs e)
		{
			base.Properties_Loaded(sender, e);

			if(BaseProperties is FileProperties fp)
			{
			}
			else if(BaseProperties is DriveProperties dp)
			{

			}
			//CompatibilityProperties?.GetCompatibilityOptions();
		}

		public override Task<bool> SaveChangesAsync()
		{
			throw new NotImplementedException();
		}
	}
}
