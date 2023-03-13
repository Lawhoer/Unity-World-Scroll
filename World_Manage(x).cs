using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_Manage : MonoBehaviour
{
    public int n;
    public float sol,sag,player_pos;
    public GameObject dosyalar;
    public static World_Manage world_manage;
    private Transform max, min;
    public PlayerMovement player;
   
    // Sistemi calistirmadan once hesap() sonra world_scroll() fonksiyonunu cagir. 

    void Start()
    {   
        world_manage = this;
        n = dosyalar.transform.childCount;
        hesap();
    }

    public void hesap()
    {
        sag = dosyalar.transform.GetChild(0).position.x;
        sol = sag;
        
        max = dosyalar.transform.GetChild(0);
        min = max;

        for (int i = 0; i < n; i++)
        {
            if (dosyalar.transform.GetChild(i).gameObject.activeSelf == true)
            {
                float temp = dosyalar.transform.GetChild(i).position.x;
                if (temp > sag)
                {
                    sag = temp;
                    max = dosyalar.transform.GetChild(i);
                }
                else if (temp < sol)
                {
                    sol = temp;
                    min = dosyalar.transform.GetChild(i);
                }
            }
        }
    }


    public void world_scroll()
    {
        player_pos = player.transform.position.x;
        float max_pos = max.transform.position.x;
        float min_pos = min.transform.position.x;
        float m = 1,n = 1;

        if (max_pos * player_pos < 0)
        {
            m = -1;
        }
       
        if (min_pos * player_pos < 0)
        {
            n = -1;
        }
        
        if(Mathf.Abs(max_pos) - (m*Mathf.Abs(player_pos)) < 80 && Mathf.Abs(Mathf.Abs(max_pos) - (m * Mathf.Abs(player_pos))) > 0)
        {
            //min i max ýn oraya götür
            min.transform.position = new Vector3(sag + 20, 0, 0);
        }

        if (Mathf.Abs(Mathf.Abs(min_pos) - (n * Mathf.Abs(player_pos))) < 80 && Mathf.Abs(Mathf.Abs(min_pos) - (n * Mathf.Abs(player_pos))) > 0)
        {
            // max ý min in oraya götür
            max.transform.position = new Vector3(sol - 20, 0, 0);   
        }
        m = 1;
        n = 1;
    }
}
