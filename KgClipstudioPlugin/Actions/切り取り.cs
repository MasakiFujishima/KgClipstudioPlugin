namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 切り取り : PluginDynamicCommand
    {
        public 切り取り()
        : base(displayName: "切り取り", description: "切り取り", groupName: "編集メニュー")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("編集メニュー.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(239,133,124));
                    bitmapBuilder.DrawText("切り取り", color: new BitmapColor(245,247,229));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(245,247,229));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyX, ModifierKey.Control);
        }
    }
}
