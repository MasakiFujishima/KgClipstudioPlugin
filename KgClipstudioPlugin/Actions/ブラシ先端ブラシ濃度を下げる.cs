namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class ブラシ先端ブラシ濃度を下げる : PluginDynamicCommand
    {
        public ブラシ先端ブラシ濃度を下げる()
        : base(displayName: "ブラシ先端 ブラシ濃度を 下げる", description: "ブラシ先端 ブラシ濃度を 下げる", groupName: "ツールプロパティパレット")
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
                    bitmapBuilder.DrawText("ブラシ先端 ブラシ濃度を 下げる", color: new BitmapColor(0,0,0));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyO, ModifierKey.Control | ModifierKey.Shift);
        }
    }
}
