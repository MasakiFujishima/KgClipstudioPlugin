namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class フォルダーを作成してレイヤーを挿入 : PluginDynamicCommand
    {
        public フォルダーを作成してレイヤーを挿入()
        : base(displayName: "フォルダーを 作成して レイヤーを 挿入", description: "フォルダーを 作成して レイヤーを 挿入", groupName: "レイヤーメニュー")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {

            var ResourcePath = EmbeddedResources.FindFile("レイヤーメニュー.png");

            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {
                if (ResourcePath == null)
                {
                    bitmapBuilder.FillRectangle(0, 0, 80, 80, new BitmapColor(188,223,201));
                    bitmapBuilder.DrawText("フォルダーを 作成して レイヤーを 挿入", color: new BitmapColor(68,13,43));
                    return bitmapBuilder.ToImage();
                }
                else
                {
                    bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(ResourcePath));
                    bitmapBuilder.DrawText("Image", color: new BitmapColor(68,13,43));
                    return bitmapBuilder.ToImage();
                }
            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyG, ModifierKey.Control);
        }
    }
}
