namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class Clipstudiopaintを終了 : PluginDynamicCommand
    {
        public Clipstudiopaintを終了()
        : base(displayName: "Clip studio paintを 終了", description: "Clip studio paintを 終了", groupName: "ファイルメニュー")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("ファイルメニュー.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(172,117,33));
                    bitmapBuilder.DrawText("Clip studio paintを 終了", color: new BitmapColor(211,223,242));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(211,223,242));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyQ, ModifierKey.Control);
        }
    }
}
