namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class タイトルバーを隠すメニューバーを隠す : PluginDynamicCommand
    {
        public タイトルバーを隠すメニューバーを隠す()
        : base(displayName: "タイトルバーを 隠す メニューバーを 隠す", description: "タイトルバーを 隠す メニューバーを 隠す", groupName: "ウィンドウメニュー")
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
                    bitmapBuilder.DrawText("タイトルバーを 隠す メニューバーを 隠す", color: new BitmapColor(238,205,225));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.Tab, ModifierKey.Shift);
        }
    }
}
