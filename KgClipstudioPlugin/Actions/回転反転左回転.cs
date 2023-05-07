namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 回転反転左回転 : PluginDynamicCommand
    {
        public 回転反転左回転()
        : base(displayName: "回転 反転 左回転", description: "回転 反転 左回転", groupName: "表示メニュー")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("表示メニュー.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(117,201,216));
                    bitmapBuilder.DrawText("回転 反転 左回転", color: new BitmapColor(37,26,25));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(37,26,25));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.Minus);
        }
    }
}
