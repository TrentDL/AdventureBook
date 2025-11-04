using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public interface IManager //short for interface manager? //ch10
{
    string State { get; set; }

    void Initialize();
 
}
