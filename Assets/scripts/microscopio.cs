using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class microscopio : MonoBehaviour {
	
	public Canvas CanvasImagens;
    
	
	//public Button Profase;
	


	
	void OnTriggerEnter2D(Collider2D collision)
    {
       
			
				CanvasImagens.enabled = true;
                
				
				


}

//if (Profase){
	//destroy(gameObject);
//}
}
