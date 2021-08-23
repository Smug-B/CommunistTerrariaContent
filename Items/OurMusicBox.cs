using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CommunistTerrariaContent.Items
{
    public class OurMusicBox : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Music Box (Anthem)");
        }

		public override void SetDefaults() {
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.OurMusicBox>();
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.LightRed;
			item.value = Item.buyPrice(gold: 2);
			item.accessory = true;
		}
	}
}