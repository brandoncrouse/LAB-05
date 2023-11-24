using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DitzelGames.FastIK;

public class WeightController : MonoBehaviour
{
    public float AffectivePower, AffectiveDistance;
    public FastIKFabric[] Targets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Targets.Length; i++)
        {
            Targets[i].AffectivePower = AffectivePower;
            Targets[i].AffectiveDistance = AffectiveDistance;
        }
    }
}
