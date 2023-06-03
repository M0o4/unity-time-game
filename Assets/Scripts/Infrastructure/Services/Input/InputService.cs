using UnityEngine;

namespace Infrastructure.Services.Input
{
    public class InputService : IInputService
    {
        private readonly IWindowsInputService _windowsInputServiceService;

        public InputService(IWindowsInputService windowsInputServiceService)
        {
            _windowsInputServiceService = windowsInputServiceService;
        }
        
        public Vector3 getClickPosition(Camera camera)
        {
            if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                return _windowsInputServiceService.getClickPosition(camera);
            }
            
            return _windowsInputServiceService.getClickPosition(camera);
        }
    }
}
