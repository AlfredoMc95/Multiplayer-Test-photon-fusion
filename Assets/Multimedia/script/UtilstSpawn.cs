using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilstSpawn
{
    public static Vector3 GetRancomSpawnPoint()
    {
        return new Vector3(Random.Range(-10,10),4, Random.Range(-10,10));
    }
}
