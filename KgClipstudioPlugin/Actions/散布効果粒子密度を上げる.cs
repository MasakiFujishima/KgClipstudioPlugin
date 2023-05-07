namespace Loupedeck.KgClipstudioPlugin
{
    using System;

    public class 散布効果粒子密度を上げる : PluginDynamicCommand
    {
        public 散布効果粒子密度を上げる()
        : base(displayName: "散布効果 粒子密度を 上げる", description: "散布効果 粒子密度を 上げる", groupName: "ツールプロパティパレット")
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
                    bitmapBuilder.DrawText("散布効果 粒子密度を 上げる", color: new BitmapColor(0,0,0));
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyL, ModifierKey.Control | ModifierKey.Shift);
        }
    }
}
