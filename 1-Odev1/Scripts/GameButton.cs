using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : MonoBehaviour
{

    [SerializeField] bool isHit=false;
    [SerializeField] float aralik = 15f;
    public void OnButtonClick()
    {
        float x = cube_managment.cube.transform.rotation.eulerAngles.x;
        // burda eulerAngles bizim gördüðümüz gibi -180 ile 180 arasý deðerler vermiyor onun yerine 0-90 ve 270-360 arasý degerler veriyor
        if ( (x<aralik || (x<90 && x>90-aralik) || (x<270 && x>270-aralik) || x>360-aralik)  && isHit == false) 
        {
            isHit = true;
            counter.Counter.InreaseCounter();
            StartCoroutine(ResetHit());
        }
    }

    // Bekleme fonksiyonu
    public IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(0.5f);
        isHit = false;
    }


}
