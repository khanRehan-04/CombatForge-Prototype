using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
public class TitleSceenManager : MonoBehaviour
{
    public void StartNetworkAsHost()
    {
        NetworkManager.Singleton.StartHost();
    }

    public void StartNewGame()
    {
        StartCoroutine(WorldSaveGameManager.Instance.LoadNewGame());
    }
}
