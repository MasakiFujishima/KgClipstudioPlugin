namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class メインカラーとサブカラーを切り替え : PluginDynamicCommand
    {
        public メインカラーとサブカラーを切り替え()
        : base(displayName: "メインカラーと サブカラーを 切り替え", description: "メインカラーと サブカラーを 切り替え", groupName: "描画色")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("描画色.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(237,125,49));
                    bitmapBuilder.DrawText("メインカラーと サブカラーを 切り替え", color: new BitmapColor(0,0,0));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyX);
        }
    }
}
