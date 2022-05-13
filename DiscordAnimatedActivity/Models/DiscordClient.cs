using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordAnimatedActivity.Models;
using DiscordRPC;

namespace DiscordAnimatedActivity.Models
{
    public class DiscordClient
    {
		private DiscordRpcClient client;

		public void Initialize()
		{
			Settings.Revert("settings.txt");
			client = new DiscordRpcClient(Settings.ClientId);
			client.Initialize();
		}
		public void SetPresence(string DetailsText = "Details", 
								string StateText = "State", 
								string LargeImageName = null, 
								string LargeImagePlaceholder = "LargeImage",
								string SmallImageName = null,
								string SmallImagePlaceholder = "SmallImage")
		{
			client.SetPresence(new RichPresence()
			{
				Details = DetailsText,
				State = StateText,
				Assets = new Assets()
				{
					LargeImageText = LargeImagePlaceholder,
					SmallImageText = SmallImagePlaceholder,
				}
			});
		}
		public void Deinitialize()
		{
			client.Dispose();
		}
	}
}
