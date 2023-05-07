namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 操作レイヤー選択 : PluginDynamicCommand
    {
        public 操作レイヤー選択()
        : base(displayName: "操作 レイヤー選択", description: "操作 レイヤー選択", groupName: "ツール")
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
                    bitmapBuilder.DrawText("操作 レイヤー選択", color: new BitmapColor(241,228,240));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyD);
        }
    }
}
