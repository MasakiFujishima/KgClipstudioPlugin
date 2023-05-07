namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 色混ぜ : PluginDynamicCommand
    {
        public 色混ぜ()
        : base(displayName: "色混ぜ", description: "色混ぜ", groupName: "ツール")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("ツール.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(38,87,45));
                    bitmapBuilder.DrawText("色混ぜ", color: new BitmapColor(241,228,240));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(241,228,240));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyJ);
        }
    }
}
