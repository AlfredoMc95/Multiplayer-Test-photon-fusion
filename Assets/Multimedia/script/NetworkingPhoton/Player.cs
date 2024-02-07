using Fusion;

public class Player : NetworkBehaviour
{
    private NetworkCharacterController _cc;

    private void Awake()
    {
        //referencia al character controller
        _cc = GetComponent<NetworkCharacterController>();
    }

    public override void FixedUpdateNetwork()
    {
        if (GetInput(out NetworkInputData data))
        {
            data.direction.Normalize();
            //movimiento: revisar como mejorar y que sea con relacion a la camara
            _cc.Move(5 * data.direction * Runner.DeltaTime);
<<<<<<< HEAD

            if (data.direction.sqrMagnitude > 0)
                _forward = data.direction;
            //dispara
            if (HasStateAuthority && delay.ExpiredOrNotRunning(Runner))
            {
                if (data.buttons.IsSet(NetworkInputData.MOUSEBUTTON0))
                {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    //cadencia de un segundo
                    delay = TickTimer.CreateFromSeconds(Runner, 1f);
=======
                    delay = TickTimer.CreateFromSeconds(Runner, 0.5f);
>>>>>>> parent of 8e1223b (3person camera, bug)
=======
                    delay = TickTimer.CreateFromSeconds(Runner, 0.5f);
>>>>>>> parent of 8e1223b (3person camera, bug)
=======
                    delay = TickTimer.CreateFromSeconds(Runner, 0.5f);
>>>>>>> parent of 8e1223b (3person camera, bug)
=======
                    delay = TickTimer.CreateFromSeconds(Runner, 0.5f);
>>>>>>> parent of 8e1223b (3person camera, bug)
=======
                    delay = TickTimer.CreateFromSeconds(Runner, 0.5f);
>>>>>>> parent of 8e1223b (3person camera, bug)
                    Runner.Spawn(_prefabBall,
                    transform.position + _forward, Quaternion.LookRotation(_forward),
                    Object.InputAuthority, (runner, o) =>
                    {
                        // Initialize the Ball before synchronizing it
                        o.GetComponent<Ball>().Init();
                    });
                }
            }
            // salto con un delay tras 1 segundo
            if (data.buttons.IsSet(NetworkInputData.SPACE))
            {
                delay = TickTimer.CreateFromSeconds(Runner, 1f);
                _cc.Jump();
            }
=======
>>>>>>> parent of 93f10a6 (fire a balll)
        }
    }
}