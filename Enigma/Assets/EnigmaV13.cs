using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnigmaV13 : MonoBehaviour
{
    public TextMeshProUGUI DecodedText;
    public TextMeshProUGUI EncodedText;
    public TextMeshProUGUI ScrambleText;
    private int[] Scramble;
    public Button Encode;
    public Button Decode;
    public Button New;
    public Button Old;
    



    // Start is called before the first frame update
    void Start()
    {
        Encode.onClick.AddListener(delegate { Encode(); });
        Decode.onClick.AddListener(delegate { Decode(); });
        New.onClick.AddListener(delegate { New(); });
        Old.onClick.AddListener(delegate { Old(); });

        Scramble = new int[106];
        for(i = 1; i <= 106; i++){
            Scramble[i] = i;
        }        
    }

    void Encode(){

    }

    void Decode(){

    }

    void New(){

    }

    void Old(){

    }

}
