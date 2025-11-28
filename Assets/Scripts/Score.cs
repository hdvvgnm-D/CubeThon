using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameManger Manger;
    void Update()
    {
        Manger.changePlayerScore();
    }
}
