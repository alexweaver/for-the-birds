using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdItemScript : MonoBehaviour {

    public Sprite BirdImage;
    public Sprite EggImage;

    public int Cost;

	public void Instantiate ()
    {
        transform.Find("Bird Image").GetComponent<Image>().sprite = BirdImage;
        transform.Find("Egg Image").GetComponent<Image>().sprite = EggImage;
        transform.Find("Cost Text").GetComponent<Text>().text = Cost.ToString();
	}
}
