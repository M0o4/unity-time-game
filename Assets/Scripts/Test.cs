using Infrastructure.Services.Input;
using UnityEngine;
using VContainer;

namespace DefaultNamespace
{
    public class Test : MonoBehaviour
    {
        private IWindowsInputService _windowsInputService;
        
        [Inject]
        public void Constructor(IWindowsInputService input)
        {
            _windowsInputService = input;
        }

        private void Start()
        {
            Debug.Log(_windowsInputService.name);
        }
    }
}