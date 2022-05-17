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
		private Button BtnFirst = new Button();
		private Button BtnSecond = new Button();
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
								string SmallImagePlaceholder = "SmallImage",
								DateTime? StartTime = null,
								DateTime? EndTime = null,
								bool FirstButtonEnabled = false,
								bool SecondButtonEnabled = false,
								string BtnFirstUrl = null,
								string BtnFirstText = null,
								string BtnSecondUrl = null,
								string BtnSecondText = null)
		{
			if (FirstButtonEnabled)
			{
				Button[] UserButtons;
				BtnFirst.Url = BtnFirstUrl;
				BtnFirst.Label = BtnFirstText;
				if (SecondButtonEnabled)
				{
					BtnSecond.Url = BtnSecondUrl;
					BtnSecond.Label = BtnSecondText;
					UserButtons = new Button[]
					{
						BtnFirst,
						BtnSecond
					};
				}
				else
                {
					UserButtons = new Button[]
					{
						BtnFirst
					};
				}
				try
				{
					client.SetPresence(new RichPresence()
					{
						Details = DetailsText,
						State = StateText,
						Assets = new Assets()
						{
							LargeImageKey = LargeImageName,
							SmallImageKey = SmallImageName,
							LargeImageText = LargeImagePlaceholder,
							SmallImageText = SmallImagePlaceholder,
						},
						Timestamps = new Timestamps()
						{
							Start = StartTime,
							End = EndTime,
						},
						Buttons = UserButtons,
					});
				}
				catch (Exception)
				{

					throw;
				}
			}
			else
			{
				client.SetPresence(new RichPresence()
				{
					Details = DetailsText,
					State = StateText,
					Assets = new Assets()
					{
						LargeImageKey = LargeImageName,
						SmallImageKey = SmallImageName,
						LargeImageText = LargeImagePlaceholder,
						SmallImageText = SmallImagePlaceholder,
					},
					Timestamps = new Timestamps()
					{
						Start = StartTime,
						End = EndTime,
					},
				});
			}
		}
		public void SetPresence(Activity activity,
								bool FirstButtonEnabled = false,
								bool SecondButtonEnabled = false,
								string BtnFirstUrl = null,
								string BtnFirstText = null,
								string BtnSecondUrl = null,
								string BtnSecondText = null)
		{
			Timestamps Time;
			if (activity.Starttime != 0)
			{
				Time = new Timestamps() { Start = DateTime.UtcNow.AddSeconds(-activity.Starttime) };
			}
			else if (activity.Stoptime != 0)
			{
				Time = new Timestamps() { End = DateTime.UtcNow.AddSeconds(activity.Stoptime) };
			}
			else Time = default(Timestamps);
			if (FirstButtonEnabled)
			{
				Button[] UserButtons;
				BtnFirst.Url = BtnFirstUrl;
				BtnFirst.Label = BtnFirstText;
				if (SecondButtonEnabled)
				{
					BtnSecond.Url = BtnSecondUrl;
					BtnSecond.Label = BtnSecondText;
					UserButtons = new Button[]
					{
						BtnFirst,
						BtnSecond
					};
				}
				else
				{
					UserButtons = new Button[]
					{
						BtnFirst
					};
				}
				try
				{
					client.SetPresence(new RichPresence()
					{
						Details = activity.Details,
						State = activity.State,
						Assets = new Assets()
						{
							LargeImageKey = activity.Largeimagekey,
							SmallImageKey = activity.Smallimagekey,
							LargeImageText = activity.Largeimageplaceholder,
							SmallImageText = activity.Smallimageplaceholder,
						},
						Timestamps = Time,
						Buttons = UserButtons,
					});
				}
				catch (Exception)
				{
					throw;
				}
			}
			else
			{
				client.SetPresence(new RichPresence()
				{
					Details = activity.Details,
					State = activity.State,
					Assets = new Assets()
					{
						LargeImageKey = activity.Largeimagekey,
						SmallImageKey = activity.Smallimagekey,
						LargeImageText = activity.Largeimageplaceholder,
						SmallImageText = activity.Smallimageplaceholder,
					},
					Timestamps = Time,
				});
			}
		}
		public void Deinitialize()
		{
			client.Dispose();
		}
	}
}
