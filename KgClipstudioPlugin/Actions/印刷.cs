namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 印刷 : PluginDynamicCommand
    {
        public 印刷()
        : base(displayName: "印刷", description: "印刷", groupName: "ファイルメニュー")
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
                    bitmapBuilder.DrawText("印刷", color: new BitmapColor(211,223,242));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyP, ModifierKey.Control);
        }
    }
}
