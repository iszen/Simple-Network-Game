using UnityEngine.Networking;

public class LocalPlayerScriptEnabler : NetworkBehaviour {

	void Start () {
        if (isLocalPlayer)
        {
            GetComponent<PlayerController>().enabled = true;
        }		
	}
	
}
