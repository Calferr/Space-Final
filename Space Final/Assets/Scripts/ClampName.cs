using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ClampName : MonoBehaviour
{
    public Text nameLabel;

    // Update is called once per frame
    void Update()
    {
        
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        nameLabel.transform.position = namePos;


        if (Camera.main.WorldToScreenPoint(this.transform.position).z < 0)
        {
            nameLabel.gameObject.SetActive(false);
        }
        else if (Camera.main.WorldToScreenPoint(this.transform.position).z > 0)
        {
            nameLabel.gameObject.SetActive(true);
        }
        

    }
}
