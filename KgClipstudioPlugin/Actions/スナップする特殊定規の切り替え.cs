namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class スナップする特殊定規の切り替え : PluginDynamicCommand
    {
        public スナップする特殊定規の切り替え()
        : base(displayName: "スナップする 特殊定規の 切り替え", description: "スナップする 特殊定規の 切り替え", groupName: "表示メニュー")
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
                    bitmapBuilder.DrawText("スナップする 特殊定規の 切り替え", color: new BitmapColor(37,26,25));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.NumPad4, ModifierKey.Control);
        }
    }
}
