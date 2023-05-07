namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 複数参照のOnOff : PluginDynamicCommand
    {
        public 複数参照のOnOff()
        : base(displayName: "複数参照の On Off", description: "複数参照の On Off", groupName: "ツールプロパティパレット")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("ツールプロパティパレット.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(237,125,49));
                    bitmapBuilder.DrawText("複数参照の On Off", color: new BitmapColor(0,0,0));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(0,0,0));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.NumPad0);
        }
    }
}
