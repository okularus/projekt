using UnityEngine; // 41 Post - Created by DimasTheDriver on July/22/2012 . Part of the 'Unity: capturing the video input from multiple webcams' post. Available at: http://www.41post.com/?p=4854.
using System.Collections;

public class SingleWebCamPreview : MonoBehaviour 
{
	//The texture that holds the video captured by the webcam
	private WebCamTexture webCamTexture;

	// Use this for initialization
	void Start () 
	{
		//Initialize the webCamTexture
		webCamTexture = new WebCamTexture();
		//Assign the images captured by the first available webcam as the texture of the containing game object
        renderer.material.mainTexture = webCamTexture;
		//Start streaming the images captured by the webcam into the texture
        webCamTexture.Play();
	}
}
