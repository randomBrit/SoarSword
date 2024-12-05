using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSMVarStore : MonoBehaviour
{
    #region, hasPlayerWon
    public bool hasPlayerWon = false;

    public void SetPlayerWon(bool hasWon)
    {
        hasPlayerWon = hasWon;
        Debug.Log("Player won: " + hasPlayerWon);
    }

    public bool CheckIfPlayerWon()
    {
        return hasPlayerWon;
    }
    #endregion
}