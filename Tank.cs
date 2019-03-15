using UnityEngine;
using UnityEngine.Networking;

public class Tank : NetworkBehaviour {

    private void FixedUpdate()
    {
        if (!isLocalPlayer)
            return;
    }

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
    }
}
