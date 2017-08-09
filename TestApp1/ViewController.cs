using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Metal;
using UIKit;

namespace TestApp1
{
    public unsafe partial class ViewController : UIViewController
    {
        private byte[] _pixelData = new byte[4000 * 4000 * 4];
        private List<IMTLTexture> _textures = new List<IMTLTexture>();

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            new Thread(() =>
            {
                var p = Process.GetCurrentProcess();

                while (true)
                {
                    Debug.WriteLine("Memory in use: {0:F1}", p.WorkingSet64 / 1024.0 / 1024);
                    Thread.Sleep(1000);
                }
            }).Start();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);


        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
        }

        partial void _button1_TouchUpInside(UIButton sender)
        {
            using (var desc = MTLTextureDescriptor.CreateTexture2DDescriptor(
                MTLPixelFormat.RGBA8Unorm,
                4000,
                4000,
                false))
            {
                var texture = MTLDevice.SystemDefault.CreateTexture(desc);

                if (_pixelData != null)
                {
                    fixed (void* ptr = _pixelData)
                    {
                        texture.ReplaceRegion(
                            MTLRegion.Create2D(0U, 0, 4000, 4000),
                            0,
                            new IntPtr(ptr),
                            4000 * 4);
                    }
                }

                _textures.Add(texture);
            }
        }

        partial void _button2_TouchUpInside(UIButton sender)
        {
            foreach (var tex in _textures)
            {
                tex.Dispose();
            }

            _textures.Clear();

            CleanMemory();
        }

        partial void _button3_TouchUpInside(UIButton sender)
        {
            CleanMemory();
        }

		partial void _button4_TouchUpInside(UIButton sender)
		{
            _pixelData = null;
            CleanMemory();
		}

        private void CleanMemory()
        {
			GC.Collect();
			GC.WaitForPendingFinalizers();

            Debug.WriteLine("Memory cleaned.");
        }
    }
}
