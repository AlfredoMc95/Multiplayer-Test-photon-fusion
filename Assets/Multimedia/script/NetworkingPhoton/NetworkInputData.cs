using Fusion;
using UnityEngine;

public struct NetworkInputData : INetworkInput
{
    // comandos que resibe 

    public const byte MOUSEBUTTON0 = 1;

    public const byte SPACE = 1;

    public NetworkButtons buttons;
    public Vector3 direction;
}