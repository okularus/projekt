using UnityEngine;
using System.Collections;

public class viniettemanager : MonoBehaviour {


		public MotionBlur mblur1;
		public MotionBlur mblur2;
		public float setPromileWartosc = 0;
		
		public Vignetting vineta1; //- nie wiem czemu zaznacza na czerwono
		public Vignetting vineta2; //- nie wiem czemu zaznacza na czerwono
		
		public TwirlEffect twirl1;
		public TwirlEffect twirl2;

	public GameObject plama1;
	public GameObject plama2;
		
	int counter;
	public KeyCode keyToCycleType = KeyCode.None;
	public GameObject nameOfD;
	public GameObject nameOfD2;
		public float motionBlurLevel = 0.01f;
		
		void Update()
		{
			if (Input.GetKeyDown ("0") || Input.GetKeyDown ("[0]")) {
				setPromileWartosc = 0.0f;

			}
			if (Input.GetKeyDown ("1") || Input.GetKeyDown ("[1]")) {
				setPromileWartosc = 1f;
				
			}
			if (Input.GetKeyDown ("2") || Input.GetKeyDown ("[2]")) {
				setPromileWartosc = 1.5f;
				
			}
			if (Input.GetKeyDown ("3") || Input.GetKeyDown ("[3]")) {
				setPromileWartosc = 2.0f;
				
			}
			if (Input.GetKeyDown ("4") || Input.GetKeyDown ("[4]")) {
				setPromileWartosc = 2.5f;
				
			}
			if (Input.GetKeyDown ("5") || Input.GetKeyDown ("[5]")) {
				setPromileWartosc = 3f;
				
			}
			if (Input.GetKeyDown ("6") || Input.GetKeyDown ("[6]")) {
				setPromileWartosc = 3.5f;
				
			}
			if (Input.GetKeyDown ("7") || Input.GetKeyDown ("[7]")) {
				setPromileWartosc = 4f;

			}
			if (Input.GetKeyDown ("8") || Input.GetKeyDown ("[8]")) {
				setPromileWartosc = 4.5f;
				
			}
			if (Input.GetKeyDown ("9") || Input.GetKeyDown ("[9]")) 
			{
				setPromileWartosc = 5.0f;
				
			}
			//debug
			// mblur1.blurAmount = motionBlurLevel;
			// mblur2.blurAmount = motionBlurLevel;
			
			//debug
			
			if (setPromileWartosc <= 0)
			{
			nameOfD2.GetComponent<TextMesh>().text = "";	
				mblur1.blurAmount = 0.0f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 0.0f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 0.0f;
				vineta2.intensity = vineta1.intensity;
				
				//Debug.Log("weszlo 0");
				
			}
			if (setPromileWartosc > 0.0f && setPromileWartosc <= 0.3f)
			{
				//Debug.Log("weszlo 0.3");
				mblur1.blurAmount = 0.2f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 0.1f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 2f;
				vineta2.intensity = vineta1.intensity;
				nameOfD2.GetComponent<TextMesh>().text = "tunnel vision";	
			}
			if (setPromileWartosc > 0.3f && setPromileWartosc <= 0.6f)
			{
				mblur1.blurAmount = 0.4f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 0.5f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 4f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision";	
			}
			if (setPromileWartosc > 0.6f && setPromileWartosc <= 0.9f)
			{
				mblur1.blurAmount = 0.6f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 0.7f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 5f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision";	
			}
			if (setPromileWartosc > 0.9f && setPromileWartosc <= 1.2f)
			{
				mblur1.blurAmount = 0.5f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 1f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 6f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision";	
			}
			if (setPromileWartosc > 1.2f && setPromileWartosc <= 1.5f)
			{
				mblur1.blurAmount = 0.52f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 1.5f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 7f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision";	
			}
			if (setPromileWartosc > 1.5f && setPromileWartosc <= 1.8f)
			{
				mblur1.blurAmount = 0.55f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 2f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 8.5f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision";	
			}
			if (setPromileWartosc > 1.8f && setPromileWartosc <= 2.1f)
			{
				mblur1.blurAmount = 0.56f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 3f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 9f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision";	
			}
			if (setPromileWartosc > 2.1f && setPromileWartosc <= 2.4f)
			{
				mblur1.blurAmount = 0.63f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 3.5f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 10f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "";	
			}
			if (setPromileWartosc > 2.4f && setPromileWartosc <= 2.7f)
			{
				mblur1.blurAmount = 0.68f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 3.7f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 25f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision 2";	
			}
			if (setPromileWartosc > 2.7f && setPromileWartosc <= 3.0f)
			{
				mblur1.blurAmount = 0.72f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 3.8f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 50f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision 2";	
			}
			if (setPromileWartosc > 3.0f && setPromileWartosc <= 3.3f)
			{
				mblur1.blurAmount = 0.76f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 4f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 100f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision 3";	
			}
			if (setPromileWartosc > 3.3f && setPromileWartosc <= 3.6f)
			{
				mblur1.blurAmount = 0.8f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 4.2f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 150f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision 4";	
			}
			if (setPromileWartosc > 3.6f && setPromileWartosc <= 3.9f)
			{
				mblur1.blurAmount = 0.82f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 4.5f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 200f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision 5";	
			}
			if (setPromileWartosc > 3.9f && setPromileWartosc <= 4.2f)
			{
				mblur1.blurAmount = 0.86f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				vineta1.blur = 5f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 250f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision 6";	
			}
			if (setPromileWartosc > 4.2f && setPromileWartosc <= 4.5f)
			{
				mblur1.blurAmount = 0.89f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 5.2f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 300f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision 7";	
			}
			if (setPromileWartosc > 4.5f && setPromileWartosc <= 4.8f)
			{
				mblur1.blurAmount = 0.90f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				
				vineta1.blur = 5.2f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 400f;
				vineta2.intensity = vineta1.intensity;
			nameOfD2.GetComponent<TextMesh>().text = "tunnel vision 8";	
			}
			if (setPromileWartosc > 4.8f && setPromileWartosc <= 5f)
			{
				//Debug.Log("weszlo 5");
				mblur1.blurAmount = 0.92f;
				mblur2.blurAmount = mblur1.blurAmount;
				
				vineta1.blur = 5.3f;
				vineta2.blur = vineta1.blur;
				vineta1.intensity = 500f;
				vineta2.intensity = vineta1.intensity;
				nameOfD2.GetComponent<TextMesh>().text = "tunnel vision 9";	 
			}
			mblur1.extraBlur = true;
			mblur2.extraBlur = true;
			
			
			
		if( Input.GetKeyDown(keyToCycleType) ) {
			if( counter < 3) counter++;
			else counter = 0;
		}
	
	if( counter == 0){
			twirl1.angle=0;
			twirl2.angle=twirl1.angle;

			plama1.active=false;
			plama2.active=false;
			nameOfD.GetComponent<TextMesh>().text = "";	
	} else if ( counter == 1) {
			twirl1.angle=50;
			twirl2.angle=twirl1.angle;

			plama1.active=true;
			plama2.active=false;
			nameOfD.GetComponent<TextMesh>().text = "retinopathy";	
	} else if ( counter == 2){
			twirl1.angle=100;
			twirl2.angle=twirl1.angle;

			plama1.active=false;
			plama2.active=true;
			nameOfD.GetComponent<TextMesh>().text = "advance retinopathy";	
	}
			
			
		}
	}
