namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 修飾キー設定 : PluginDynamicCommand
    {
        public 修飾キー設定()
        : base(displayName: "修飾キー 設定", description: "修飾キー 設定", groupName: "ファイルメニュー")
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
                    bitmapBuilder.DrawText("修飾キー 設定", color: new BitmapColor(211,223,242));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyY, ModifierKey.Control | ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
