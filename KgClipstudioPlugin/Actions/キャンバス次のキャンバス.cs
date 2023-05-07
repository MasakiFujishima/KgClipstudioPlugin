namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class キャンバス次のキャンバス : PluginDynamicCommand
    {
        public キャンバス次のキャンバス()
        : base(displayName: "キャンバス 次の キャンバス", description: "キャンバス 次の キャンバス", groupName: "ウィンドウメニュー")
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
                    bitmapBuilder.DrawText("キャンバス 次の キャンバス", color: new BitmapColor(238,205,225));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.Tab, ModifierKey.Control);
        }
    }
}
