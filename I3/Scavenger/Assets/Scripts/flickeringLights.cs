using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickeringLights : MonoBehaviour {

    // Use this for initialization

    Light testLight;
    public float minWaitTime;
    public float maxWaitTime;



    void Start() {

        testLight = GetComponent<Light>();
        StartCoroutine(FlashingLight());

    }

    IEnumerator FlashingLight ()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime,maxWaitTime));

            testLight.enabled = ! testLight.enabled;

        }

    }

	// Update is called once per frame
	void Update () {
		
	}
}
