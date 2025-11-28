using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManger gameManger;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            gameManger.WinGame();
        }
    }
}
