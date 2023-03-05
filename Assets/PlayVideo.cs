using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public VideoPlayer vp;
    public ClipRenderer r;
    public CamToFeed cf;
    public GameObject UI;
    string currStr = "";
    public string tag = "Player";
    public int ind = 0;
    // Start is called before the first frame update
    void OnEnable()
    {
        currStr = vp.url;
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        //print(other + " " +  tag + "  " + currStr);
        if (other.tag == tag)
        {
            if (ind >= 0 && Game_Data.Videos != null && vp.url != Game_Data.Videos[ind].downloadUrl)
            {
                print("PLAY! " + ind);
                r.PlayIndex(ind);
                if (UI != null)
                    UI.SetActive(true);
            }
            else if (ind == -1)
            {
                if (cf != null && !cf.enabled)
                {
                    cf.enabled = true;
                    if (UI != null)
                        UI.SetActive(true);
                }
            }
        }
    }

    private void Update()
    {
        if (Input.GetKey("x"))
        {
            r.Stop();
        }
    }
}
