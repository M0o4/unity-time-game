using UnityEngine;

namespace Infrastructure.Services.Input
{
    public class WindowsInputService: IWindowsInputService
    {
        public Vector3 getClickPosition(Camera camera)
        {
            var mousePos = UnityEngine.Input.mousePosition;
            mousePos.z = camera.nearClipPlane;
            return camera.ScreenToWorldPoint(mousePos);
        }

        public string name { get; set; } = "Hello World!";
    }
}