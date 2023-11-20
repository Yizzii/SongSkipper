using TLDLoader;
using UnityEngine.InputSystem;
namespace SongSkipper
{
	public class Main : Mod
	{
		public override string ID { get { return "Song Skipper"; } }
		public override string Name { get { return "Song Skipper"; } }
		public override string Author { get { return "Yizzi"; } }
		public override string Version { get { return "1.0.0"; } }
		bool keyp;
        public override void Update()
        {
            if (Keyboard.current.equalsKey.isPressed)
            {
                if (!keyp)
                {
                    mainscript.M.customRadio.LoadRandomSong();
                }
                keyp = true;
            }
            else
            {
                keyp = false;
            }
        }
    }
}
