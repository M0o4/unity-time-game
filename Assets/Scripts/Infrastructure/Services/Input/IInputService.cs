using UnityEngine;

namespace Infrastructure.Services.Input
{
    public interface IInputService
    {
        Vector3 getClickPosition(Camera camera);
    }
}