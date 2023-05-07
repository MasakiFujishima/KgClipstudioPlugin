namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class レイヤーカラーの使用切り替え : PluginDynamicCommand
    {
        public レイヤーカラーの使用切り替え()
        : base(displayName: "レイヤー カラーの 使用 切り替え", description: "レイヤー カラーの 使用 切り替え", groupName: "レイヤープロパティパレット")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("レイヤープロパティパレット.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(0,0,0));
                    bitmapBuilder.DrawText("レイヤー カラーの 使用 切り替え", color: new BitmapColor(255,255,255));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(255,255,255));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyB, ModifierKey.Control);
        }
    }
}
