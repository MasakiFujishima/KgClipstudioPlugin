namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class すべてのパレットを表示する隠す : PluginDynamicCommand
    {
        public すべてのパレットを表示する隠す()
        : base(displayName: "すべての パレットを 表示する 隠す", description: "すべての パレットを 表示する 隠す", groupName: "ウィンドウメニュー")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("ウィンドウメニュー.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(149,85,158));
                    bitmapBuilder.DrawText("すべての パレットを 表示する 隠す", color: new BitmapColor(238,205,225));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(238,205,225));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.Tab);
        }
    }
}
