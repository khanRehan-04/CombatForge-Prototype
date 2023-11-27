using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerUIManager : MonoBehaviour
{
    public static PlayerUIManager instance;

    [Header("NETWORK JOIN")]
    [SerializeField] bool startGameAsClient;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


    private void Update()
    {
        if (startGameAsClient)
        {
            startGameAsClient = false;

            NetworkManager.Singleton.Shutdown();  // this will shutdown the network as a host
                                
            NetworkManager.Singleton.StartClient(); // this will start network as a client
        }
    }
}
