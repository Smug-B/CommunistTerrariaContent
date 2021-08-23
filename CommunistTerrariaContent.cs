using Terraria;
using Terraria.ModLoader;

namespace CommunistTerrariaContent
{
	public class CommunistTerrariaContent : Mod
	{
        public override void Load() {
            if (!Main.dedServ) {
                AddMusicBox(CommunistTerraria.CommunistTerraria.Mod.GetSoundSlot(SoundType.Music, "Sounds/Music/StateAnthemOfTheUSSR"), ModContent.ItemType<Items.OurMusicBox>(), ModContent.TileType<Tiles.OurMusicBox>());
            }
        }
    }
}