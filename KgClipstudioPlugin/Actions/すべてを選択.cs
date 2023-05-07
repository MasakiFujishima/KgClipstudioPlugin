namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class すべてを選択 : PluginDynamicCommand
    {
        public すべてを選択()
        : base(displayName: "すべてを 選択", description: "すべてを 選択", groupName: "選択範囲メニュー")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("選択範囲メニュー.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(190,190,190));
                    bitmapBuilder.DrawText("すべてを 選択", color: new BitmapColor(4,0,0));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(4,0,0));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyA, ModifierKey.Control);
        }
    }
}
