using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeeper : MonoBehaviour {

    public double getTime(){
        System.DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
        return (System.DateTime.UtcNow - epochStart).TotalSeconds;
        print("done");

    }

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        print(getTime());
	}
}
