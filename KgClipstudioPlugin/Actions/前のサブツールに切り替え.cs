namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 前のサブツールに切り替え : PluginDynamicCommand
    {
        public 前のサブツールに切り替え()
        : base(displayName: "前の サブツールに 切り替え", description: "前の サブツールに 切り替え", groupName: "サブツールパレット")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("サブツールパレット.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(68,114,196));
                    bitmapBuilder.DrawText("前の サブツールに 切り替え", color: new BitmapColor(255,192,0));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(255,192,0));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.Comma);
        }
    }
}
