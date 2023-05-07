namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 現在よりサイズの小さいプリセットを選択 : PluginDynamicCommand
    {
        public 現在よりサイズの小さいプリセットを選択()
        : base(displayName: "現在より サイズの 小さい プリセットを選択", description: "現在より サイズの 小さい プリセットを選択", groupName: "ブラシサイズパレット")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("ブラシサイズパレット.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(255,192,0));
                    bitmapBuilder.DrawText("現在より サイズの 小さい プリセットを選択", color: new BitmapColor(0,0,0));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.Oem4);
        }
    }
}
