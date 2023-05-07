namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 表示位置をリセット : PluginDynamicCommand
    {
        public 表示位置をリセット()
        : base(displayName: "表示位置を リセット", description: "表示位置を リセット", groupName: "表示メニュー")
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
                    bitmapBuilder.DrawText("表示位置を リセット", color: new BitmapColor(37,26,25));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.Oem3, ModifierKey.Control);
        }
    }
}
