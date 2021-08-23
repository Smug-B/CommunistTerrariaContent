using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Audio;

namespace CommunistTerrariaContent
{
	public class CommunistTerrariaContent : Mod
	{
        public override void Load() {
            if (!Main.dedServ) {
                AddMusicBox(CommunistTerraria.CommunistTerraria.Mod.GetSoundSlot(SoundType.Music, "Sounds/Music/StateAnthemOfTheUSSR"), ModContent.ItemType<Items.OurMusicBox>(), ModContent.TileType<Tiles.OurMusicBox>());
            }
        }

        public override void Close() {
            int soundSlot = CommunistTerraria.CommunistTerraria.Mod.GetSoundSlot(SoundType.Music, "Sounds/Music/StateAnthemOfTheUSSR");
            if (Main.music.IndexInRange(soundSlot)) {
                var check = Main.music[soundSlot];
                if (check != null && check.IsPlaying) {
                    Main.music[soundSlot].Stop(AudioStopOptions.Immediate);
                }
            }
            base.Close();
        }
    }
}