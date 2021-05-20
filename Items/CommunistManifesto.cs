using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CommunistTerrariaContent.Items
{
    public class CommunistManifesto : ModItem
    {
        private static CommunistTerraria.CommunistTerraria Mod => ModContent.GetInstance<CommunistTerraria.CommunistTerraria>();
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Communist Manifesto");
            Tooltip.SetDefault("Authors: Karl Marx & Friedrich Engels"
            + "\nLeft click when holding to open the manifesto");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 46;

            item.rare = ItemRarityID.Red;
            item.useAnimation = 48;
            item.useTime = 48;
            // item.noUseGraphic = true;
            item.useStyle = ItemUseStyleID.HoldingUp;
        }

        public override bool UseItem(Player player)
        {
            Mod.ToggleManifestoUI();
            return true;
        }
    }
}