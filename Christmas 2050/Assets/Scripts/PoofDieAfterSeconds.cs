using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoofDieAfterSeconds : MonoBehaviour {
    private IEnumerator Start()
    {
            print(Time.time);
            yield return new WaitForSeconds(5);
            print(Time.time);
        } 
}
