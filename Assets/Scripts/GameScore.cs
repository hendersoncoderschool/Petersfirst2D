using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public List<GameObject> Plates;
    public GameObject Teleporter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool allActive = true;
        for(int i = 0; i < Plates.Count; i++){
            if(Plates[i].GetComponent<Plates>().active == false) allActive = false;
            //print(Plates[i].GetComponent<Plates>().active);
        }
        //print(allActive);

        if(allActive == true){
            Teleporter.SetActive(true);
        }
        else Teleporter.SetActive(false);
        
    }
}
