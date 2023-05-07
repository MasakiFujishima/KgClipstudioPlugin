namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 下のレイヤーと結合 : PluginDynamicCommand
    {
        public 下のレイヤーと結合()
        : base(displayName: "下の レイヤーと 結合", description: "下の レイヤーと 結合", groupName: "レイヤーメニュー")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("レイヤーメニュー.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(188,223,201));
                    bitmapBuilder.DrawText("下の レイヤーと 結合", color: new BitmapColor(68,13,43));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(68,13,43));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyE, ModifierKey.Control);
        }
    }
}
