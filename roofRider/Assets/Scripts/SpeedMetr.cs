using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpeedMetr : MonoBehaviour
{

    public float Currentspeed;

    public Text SpeedDebug;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CalcSpeed());
    }

    IEnumerator CalcSpeed()
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            Vector3 prevPos = transform.position;

            yield return new WaitForFixedUpdate();

            Currentspeed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);
            SpeedDebug.text = "Speed: " + Currentspeed.ToString();
        }
    }

}
