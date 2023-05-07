namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 選択を解除 : PluginDynamicCommand
    {
        public 選択を解除()
        : base(displayName: "選択を 解除", description: "選択を 解除", groupName: "選択範囲メニュー")
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
                    bitmapBuilder.DrawText("選択を 解除", color: new BitmapColor(4,0,0));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyD, ModifierKey.Control);
        }
    }
}
