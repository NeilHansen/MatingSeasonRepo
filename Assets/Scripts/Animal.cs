using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

    Gene heatAffinity, carnivority, litterSize, cancerSusceptibility;


    public Animal(int[] heat, int[] carn, int[] litt, int[] canc)
    {
        heatAffinity = new Gene(heat);
        carnivority = new Gene(carn);
        litterSize = new Gene(litt);
        cancerSusceptibility = new Gene(canc);
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}





    class Gene
    {
        int[] sequence;

        public Gene(int[] seq)
        {
            sequence = seq;
        }


        public int[] getHalf()
        {
            int f;
            int i = Random.Range(0, sequence.Length /2);
            do
            {
                f = Random.Range(0, sequence.Length / 2);
            } while (i == f);   // WE dont want the same gene twice
            int[] temp = new int[2] { i, f };
            return temp;
        }

        public float getPerc()
        {
            int total = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                total += sequence[i];
            }
            float perc = ((float)total) / ((float)sequence.Length);
            return perc;
        }
       
        
    }

}
