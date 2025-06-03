using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace Scp096Bag
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;

		public bool Debug { get; set; } = false;

		[Description("How many seconds does it take to put on a mask on 096")]
		public int SecondsToUse { get; set; } = 10;

		[Description("Is the mask removed from 096 if he is shot at?")]
		public bool IsMaskOffByDamage { get; set; } = false;
		[Description("List of roles spawning with Bag")]
		public List<RoleTypeId> AllowedRoles { get; set; } = new List<RoleTypeId>
		{
			RoleTypeId.NtfCaptain,
			RoleTypeId.NtfSpecialist,
			RoleTypeId.NtfSergeant
		};
	}
}
