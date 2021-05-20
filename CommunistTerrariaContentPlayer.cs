using System.Collections.Generic;
using CommunistTerrariaContent.Items;
using Terraria;
using Terraria.ModLoader;

namespace CommunistTerraria
{
	public class CommunistTerrariaContentPlayer : ModPlayer
    {
		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
		{
			Item manifesto = new Item();
			manifesto.SetDefaults(ModContent.ItemType<CommunistManifesto>());
			items.Add(manifesto);
		}
	}
}